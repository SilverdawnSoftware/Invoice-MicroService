namespace InvoiceingMicroServiceTests.Config
{
    public class EmailSettings
    {
        public string SMTPEmailFromAddress { get; set; }

        public string SMTPUserName { get; set; }

        public string SMTPPassword { get; set; }

        public string SMTPHost { get; set; }

        public string SMTPEmailDisplayName { get; set; }

        public string TestEmailSendAddress { get; set; }
    }
}
