using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using SilverdawnSoftware.Invoice.CQRS.Commands.Customer;
using SilverdawnSoftware.Invoice.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models;
using SilverdawnSoftware.Invoice.CQRS.Commands.Entity;
using SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine;
using SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.Models;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using Xunit;

using EntityAdd = SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models.EntityAdd;

namespace InvoiceingMicroServiceTests
{
    public class InvoiceTests
    {
        private ICustomerView customerView;

        public InvoiceTests()
        {
            var entityName = Guid.NewGuid().ToString();
            var entityAddCommand = new EntityAddCommand();

            IEntityView _entityView;

            _entityView = entityAddCommand.EntityAdd(new EntityAdd()
            {
                Name = entityName,
                SMTPEmailFromAddress = Config.Config.EmailSettings.SMTPEmailFromAddress,
                SMTPHost = Config.Config.EmailSettings.SMTPHost,
                SMTPEmailDisplayName = Config.Config.EmailSettings.SMTPEmailDisplayName,
                SMTPPassword = Config.Config.EmailSettings.SMTPPassword,
                SMTPUserName = Config.Config.EmailSettings.SMTPUserName,
                Address = new AddressView()
                {
                    AddressLine1 = "4490  Patterson Street",
                    City = "Houston",
                    StateCounty = "State",
                    PostZipCode = "77063"
                }
            }).Result;


            var name = Guid.NewGuid().ToString();
            var customerAddCommand = new CustomerAddCommand();

            customerView = customerAddCommand.CustomerAdd(new CustomerAdd()
            {
                EntityId = _entityView.EntityId,
                Name = name,
                EmalAddress = Config.Config.EmailSettings.TestEmailSendAddress
            }).Result;
        }

        [Fact]
        public async void InvoiceAddTest()
        {

            var purchaseOrderRef = Guid.NewGuid().ToString();
            var invoiceAddCommand = new InvoiceAddCommand();

            var invoiceView = await invoiceAddCommand.InvoiceAdd(new SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceAdd()
            {
                PurchaseOrderRef = purchaseOrderRef,
              
                CustomerId = customerView.CustomerId
            });

            invoiceView.__CQRSErrorMessage.Should().BeNullOrWhiteSpace();
            invoiceView.PurchaseOrderRef.Should().Be(purchaseOrderRef);
          
            invoiceView.InvoiceId.Should().BeGreaterThan(0);

        }



        [Fact]
        public async void InvoiceFindTest()
        {
            var purchaseOrderRef = Guid.NewGuid().ToString();
            var invoiceAddCommand = new InvoiceAddCommand();

            var invoiceView = await invoiceAddCommand.InvoiceAdd(new SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceAdd()
            {
                PurchaseOrderRef = purchaseOrderRef,

                CustomerId = customerView.CustomerId
            });

            invoiceView.__CQRSErrorMessage.Should().BeNullOrWhiteSpace();
            invoiceView.PurchaseOrderRef.Should().Be(purchaseOrderRef);

            invoiceView.InvoiceId.Should().BeGreaterThan(0);

            var find = new GetInvoiceRequest();

            var result2 = find.GetInvoice(new GetInvoice()
            {
                InvoiceNo = invoiceView.InvoiceNo
            }).Result;


            result2.PurchaseOrderRef.Should().Be(purchaseOrderRef);
            result2.InvoiceId.Should().Be(invoiceView.InvoiceId);
        }

        [Fact]
        public async void InvoiceEmailTest()
        {
            var purchaseOrderRef = Guid.NewGuid().ToString();
            var invoiceAddCommand = new InvoiceAddCommand();
            var invoiceLineAddCommand = new InvoiceLineAddCommand();

            var invoiceView = await invoiceAddCommand.InvoiceAdd(new SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceAdd()
            {
                PurchaseOrderRef = purchaseOrderRef,
                CustomerId = customerView.CustomerId,
                EmailTo = Config.Config.EmailSettings.TestEmailSendAddress,
                OrderedBy = "Joe Blogs",
                BillingAddress = new AddressView()
                {
                    AddressLine1 = "287  Denver Avenue",
                    City = "City Of Commerce",
                    StateCounty = "CA",
                    PostZipCode = "90040",
                }
            });

            for (int i = 0; i < 5; i++)
            {
                var invoiceLine = await invoiceLineAddCommand.InvoiceLineAdd(new InvoiceLineAdd()
                {
                    InvoiceId = invoiceView.InvoiceId,
                    ProductCode = "ABC"+i,
                    UnitCost = i,
                    Quantity = i,
                    SubTotal = i*i,
                    TaxTotal = (decimal) ((i*i)*.125),
                    LineTotal = (decimal)((i * i) * 1.125)
                });
            }


            invoiceView.__CQRSErrorMessage.Should().BeNullOrWhiteSpace();
            invoiceView.PurchaseOrderRef.Should().Be(purchaseOrderRef);

            invoiceView.InvoiceId.Should().BeGreaterThan(0);

            var email = new InvoiceEmailCommand();

            var result2 = await email.InvoiceEmail(new InvoiceEmail()
            {
                InvoiceId = invoiceView.InvoiceId
            });

            result2.PurchaseOrderRef.Should().Be(purchaseOrderRef);
            result2.InvoiceId.Should().Be(invoiceView.InvoiceId);
        }


    }
}
