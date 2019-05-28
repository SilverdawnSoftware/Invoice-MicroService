using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using SilverdawnSoftware.Invoice.CQRS.Commands.Counter;
using SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Counter;
using SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Counter.Models;
using Xunit;

namespace InvoiceingMicroServiceTests
{
    public class CounterTests
    {
        [Fact]
        public void CounterAddTest()
        {
            var name = Guid.NewGuid().ToString();
            var add = new CounterAddCommand();

            var result = add.CounterAdd(new CounterAdd()
            {
                Name = name,
                Value = 1000
            }).Result;

            result.Name.Should().Be(name);
           
        }


        [Fact]
        public void CounterFindTest()
        {
            var name = Guid.NewGuid().ToString();
            var add = new CounterAddCommand();

            var result = add.CounterAdd(new CounterAdd()
            {
                Name = name,
                Value = 1000
            }).Result;

            result.Name.Should().Be(name);
            result.Value.Should().Be(1000);
           

            var find = new GetCounterRequest();

            var result2 = find.GetCounter(new GetCounter()
            {
                Name = result.Name
            }).Result;


            result2.Name.Should().Be(name);
            result2.Value.Should().Be(1000);


        }



        [Fact]
        public void CounterNextTest()
        {
            var name = Guid.NewGuid().ToString();
            var add = new CounterAddCommand();

            var result = add.CounterAdd(new CounterAdd()
            {
                Name = name,
                Value = 1000
            }).Result;

            result.Name.Should().Be(name);
            result.Value.Should().Be(1000);


            var next = new CounterNextCommand();
            var nextResult = next.CounterNext(new CounterNext() {Name = name}).Result;

            nextResult.Value.Should().Be(1001);

            var find = new GetCounterRequest();

            var result2 = find.GetCounter(new GetCounter()
            {
                Name = result.Name
            }).Result;


            result2.Name.Should().Be(name);
            result2.Value.Should().Be(1001);


        }
    }
}
