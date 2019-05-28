using System;
using System.Linq;
using FluentAssertions;
using SilverdawnSoftware.Invoice.CQRS.Commands.Entity;
using SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity.Models;
using Xunit;

namespace InvoiceingMicroServiceTests
{

    public class EntityTests
    {
        [Fact]
        public void EntityAddTest()
        {
            var name = Guid.NewGuid().ToString();
            var add = new EntityAddCommand();

            var result = add.EntityAdd(new EntityAdd()
            {
                Name = name
            }).Result;

            result.Name.Should().Be(name);
            result.AddressAddressId.Should().Be(0);
            result.EntityId.Should().BeGreaterThan(0);
        }


        [Fact]
        public void EntityFindTest()
        {
            var name = Guid.NewGuid().ToString();
            var add = new EntityAddCommand();

            var result = add.EntityAdd(new EntityAdd()
            {
                Name = name
            }).Result;

            result.Name.Should().Be(name);
            result.AddressAddressId.Should().Be(0);
            result.EntityId.Should().BeGreaterThan(0);

            var find = new GetEntityRequest();

            var result2 = find.GetEntity(new GetEntity()
            {
                EntityId = result.EntityId
            }).Result;


            result2.Name.Should().Be(name);
            result2.AddressAddressId.Should().Be(0);
            result2.EntityId.Should().Be(result.EntityId);

        }


        [Fact]
        public void EntitySearchTest()
        {
            var name = Guid.NewGuid().ToString();
            var add = new EntityAddCommand();

            var result = add.EntityAdd(new EntityAdd()
            {
                Name = name
            }).Result;

            result.Name.Should().Be(name);
            result.AddressAddressId.Should().Be(0);
            result.EntityId.Should().BeGreaterThan(0);

            var find = new SearchEntityByNameRequest();

            var result2 = find.SearchEntityByName(new SearchEntityByName()
            {
                Name = result.Name
            }).Result;

            result2.Count.Should().Be(1);

            result2.First().Name.Should().Be(name);
            result2.First().AddressAddressId.Should().Be(0);
            result2.First().EntityId.Should().Be(result.EntityId);

        }


    }
}