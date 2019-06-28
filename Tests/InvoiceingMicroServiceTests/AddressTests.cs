using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using SilverdawnSoftware.Invoice.CQRS.Commands.Customer;
using SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models;

using SilverdawnSoftware.Invoice.CQRS.Commands.Entity;
using SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models;

using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using Xunit;

namespace InvoiceingMicroServiceTests
{
    public class AddressTests
    {

        private ICustomerView customerView;

        public  AddressTests()
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


    //    [Fact]
    //    public async void AddressAddTest()
    //    {

    //        var addressLine1 = Guid.NewGuid().ToString();
    //        var addressAddCommand = new AddressAddCommand();

    //        var addressView = await addressAddCommand.AddressAdd(new AddressAdd()
    //        {
    //            AddressLine1 = addressLine1,
    //            Country = "New Zealand",
    //            CustomerId = customerView.CustomerId
    //        });

    //        addressView.__CQRSErrorMessage.Should().BeNullOrWhiteSpace();
    //        addressView.AddressLine1.Should().Be(addressLine1);
    //        addressView.Country.Should().Be("New Zealand");
    //        addressView.AddressId.Should().BeGreaterThan(0);
          
    //}

      

    //    [Fact]
    //    public void AddressFindTest()
    //    {
    //        var addressLine1 = Guid.NewGuid().ToString();
    //        var add = new AddressAddCommand();

    //        var result = add.AddressAdd(new AddressAdd()
    //        {
    //            AddressLine1 = addressLine1,
    //            Country = "New Zealand",
    //            CustomerId = customerView.CustomerId

    //        }).Result;

    //        result.AddressLine1.Should().Be(addressLine1);
    //        result.Country.Should().Be("New Zealand");
    //        result.AddressId.Should().BeGreaterThan(0);

    //        var find = new GetAddressRequest();

    //        var result2 = find.GetAddress(new GetAddress()
    //        {
    //            AddressId = result.AddressId
    //        }).Result;


    //        result2.AddressLine1.Should().Be(addressLine1);
    //        result2.Country.Should().Be("New Zealand");
    //        result2.AddressId.Should().Be(result.AddressId);
            
    //    }


     
    }
}
