// ALLOWOVERWRITE-36B62C1347D8A014BA330DB11802F01A
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using FluentEmail.Core;
using FluentEmail.Smtp;
using RazorLight;
using SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Templates;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice
{
    public partial class InvoiceEmailCommand : Orleans.Grain, IInvoiceEmailCommand
    {


        public async Task<IInvoiceView> InvoiceEmail(IInvoiceEmail invoiceEmail)
        {
            try
            {
                var result = new InvoiceView();
                using (var db = new InvoiceContext())
                {
                    if (db.Invoices.Any(w => w.InvoiceId == invoiceEmail.InvoiceId))
                    {
                        var invoice = db.Invoices.First(w => w.InvoiceId == invoiceEmail.InvoiceId);

                        //create invoice document

                        //var sender = new SmtpSender(() => new SmtpClient(invoice.Customer.Entity.SMTPHost)
                        //{
                        //    EnableSsl = true,
                        //    Credentials = new NetworkCredential(invoice.Customer.Entity.SMTPUserName, invoice.Customer.Entity.SMTPPassword)
                        //    //DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                        //    //PickupDirectoryLocation = Path.GetTempPath()
                        //});

                        //Email.DefaultSender = sender;

                        //var email = new Email(invoice.Customer.Entity.SMTPEmailFromAddress, invoice.Customer.Entity.SMTPEmailDisplayName)
                        //    .To(invoice.Customer.EmalAddress)
                        //    .Subject($"Invoice {invoice.InvoiceNo} from {invoice.Customer.Entity.Name}");
                        ////.UsingTemplateFromFile($"{Directory.GetCurrentDirectory()}/Commands/Invoice/Templates/DefaultInvoice.cshtml",
                        ////    new {Invoice = invoice});

                        //await email.SendAsync();

                        var templateModel = new InvoiceEmailModel()
                        {
                            Invoice = invoice,
                            BillingAddress = invoice.BillingAddress,
                            EntityAddress = invoice.Customer.Entity.Address
                        };


                        var mailMessage = new MailMessage {
                            Subject = $"Invoice {invoice.InvoiceNo} from {invoice.Customer.Entity.Name}",
                            Body = TransformTemplate(templateModel, @"Commands/Invoice/Templates/DefaultInvoice.cshtml"),
                            From = new MailAddress(invoice.Customer.Entity.SMTPEmailFromAddress),
                            IsBodyHtml = true,
                            To = { new MailAddress(invoice.Customer.EmailAddress),new MailAddress(invoice.EmailTo) }
                        };
                        //mailMessage.To.Add();
                        //mailMessage.IsBodyHtml = true;

                        using (var client = new System.Net.Mail.SmtpClient(invoice.Customer.Entity.SMTPHost, 587))
                        {
                            // Pass SMTP credentials
                            client.Credentials = new NetworkCredential(invoice.Customer.Entity.SMTPUserName, invoice.Customer.Entity.SMTPPassword);

                            // Enable SSL encryption
                            client.EnableSsl = true;
                            client.Send(mailMessage);
                        }

                        result.CreatedDate = invoice.CreatedDate;
                        result.DueDate = invoice.DueDate;
                        result.EmailTo = invoice.EmailTo;
                        result.GrandTotal = invoice.GrandTotal;
                        result.InvoiceEmailed = invoice.InvoiceEmailed;
                        result.InvoiceId = invoice.InvoiceId;
                        result.InvoiceNo = invoice.InvoiceNo;
                        result.OrderedBy = invoice.OrderedBy;
                        result.PaidAmount = invoice.PaidAmount;
                        result.PaidDate = invoice.PaidDate;
                        result.PaidTax = invoice.PaidTax;
                        result.PaymentDetails = invoice.PaymentDetails;
                        result.PurchaseOrderRef = invoice.PurchaseOrderRef;
                        result.SubTotal = invoice.SubTotal;
                        result.Tax = invoice.TaxTotal;
                        result.TermsAndConditions = invoice.TermsAndConditions;
                        return result;
                    }
                }
            }
            catch (Exception exception)
            {
                LogFactory.GetLogger().Log(LogLevel.Error, exception);
                return new InvoiceView() {__CQRSSuccessful = false, __CQRSErrorMessage = "Unable to create InvoiceView", __CQRSStatusCode = 500};
            }

            return null;
        }


        public static string TransformTemplate(object data, string templatePath)
        {

            var engine = new RazorLightEngineBuilder()
                .UseFilesystemProject(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                .UseMemoryCachingProvider()
                .Build();

            //    var template = File.ReadAllText(templatePath);

            var email = engine.CompileRenderAsync(templatePath, data).Result;

            return email;
        }
    }



}
