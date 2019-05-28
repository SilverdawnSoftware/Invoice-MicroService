using System;
using System.Linq;
using FluentAssertions;
using SilverdawnSoftware.Invoice.CQRS.Commands.Customer;
using SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models;

using SilverdawnSoftware.Invoice.CQRS.Commands.Entity;
using SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.Models;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using Xunit;

namespace InvoiceingMicroServiceTests
{

    public class CustomerTests
    {

        private IEntityView _entityView;

        public CustomerTests()
        {

            var name = Guid.NewGuid().ToString();
            var add = new EntityAddCommand();

            _entityView = add.EntityAdd(new EntityAdd()
            {
                Name = name
            }).Result;



        }

        [Fact]
        public void CustomerAddTest()
        {
            var name = Guid.NewGuid().ToString();
            var add = new CustomerAddCommand();

            var result = add.CustomerAdd(new CustomerAdd()
            {
                EntityId = _entityView.EntityId,
                Name = name
            }).Result;

            result.Name.Should().Be(name);
            result.CustomerId.Should().BeGreaterThan(0);
            result.EntityId.Should().Be(_entityView.EntityId);
        }


        [Fact]
        public async void CustomerFindTest()
        {
            var name = Guid.NewGuid().ToString();
            var add = new CustomerAddCommand();

            var result = add.CustomerAdd(new CustomerAdd()
            {
                EntityId = _entityView.EntityId,
                Name = name
            }).Result;

            result.Name.Should().Be(name);
            result.CustomerId.Should().BeGreaterThan(0);
            result.EntityId.Should().Be(_entityView.EntityId);
        
            var find = new GetCustomerRequest();

            var result2 = await find.GetCustomer(new GetCustomer()
            {
                CustomerId = result.CustomerId
            });


            result2.Name.Should().Be(name);
            result2.CustomerId.Should().Be(result.CustomerId);
            result2.EntityId.Should().Be(_entityView.EntityId);

        }


        //[Fact]
        //public void CustomerSearchTest()
        //{
        //    var name = Guid.NewGuid().ToString();
        //    var add = new CustomerAddCommand();

        //    var result = add.CustomerAdd(new CustomerAdd()
        //    {
        //        Name = name
        //    }).Result;

        //    result.Name.Should().Be(name);
        //    result.AddressAddressId.Should().Be(0);
        //    result.CustomerId.Should().BeGreaterThan(0);

        //    var find = new SearchCustomerByNameRequest();

        //    var result2 = find.SearchCustomerByName(new SearchCustomerByName()
        //    {
        //        Name = result.Name
        //    }).Result;

        //    result2.Count.Should().Be(1);

        //    result2.First().Name.Should().Be(name);
        //    result2.First().AddressAddressId.Should().Be(0);
        //    result2.First().CustomerId.Should().Be(result.CustomerId);

        //}


    }
}