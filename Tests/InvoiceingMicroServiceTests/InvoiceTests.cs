using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using SilverdawnSoftware.Invoice.CQRS.Commands.Customer;
using SilverdawnSoftware.Invoice.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models;
using SilverdawnSoftware.Invoice.CQRS.Commands.Entity;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.Models;

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
                Name = entityName
            }).Result;


            var name = Guid.NewGuid().ToString();
            var customerAddCommand = new CustomerAddCommand();

            customerView = customerAddCommand.CustomerAdd(new CustomerAdd()
            {
                EntityId = _entityView.EntityId,
                Name = name
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


    }
}
