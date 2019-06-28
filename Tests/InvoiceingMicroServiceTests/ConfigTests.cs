using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;



namespace InvoiceingMicroServiceTests
{
    public class ConfigTests
    {

        [Fact]
        public void GetSMTPEmailAddress()
        {
            var config = new Config.Config();

            var email = Config.Config.EmailSettings.SMTPEmailFromAddress;

            email.Should().NotBeNullOrWhiteSpace();
        }
    }
}
