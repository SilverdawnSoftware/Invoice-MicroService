﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.Database.Migrations
{
    [DbContext(typeof(InvoiceContext))]
    [Migration("20190617132917_taxtotal")]
    partial class taxtotal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.Counter", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Value");

                    b.HasKey("Name");

                    b.ToTable("Counters");
                });

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CustomerExteranlRef");

                    b.Property<string>("EmailAddress");

                    b.Property<int?>("EntityId");

                    b.Property<bool>("IsCompany");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("TaxNo");

                    b.HasKey("CustomerId");

                    b.HasIndex("EntityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.Entity", b =>
                {
                    b.Property<int>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityExternalRef");

                    b.Property<string>("LogoURL");

                    b.Property<string>("Name");

                    b.Property<string>("SMTPEmailDisplayName");

                    b.Property<string>("SMTPEmailFromAddress");

                    b.Property<string>("SMTPHost");

                    b.Property<string>("SMTPPassword");

                    b.Property<string>("SMTPUserName");

                    b.HasKey("EntityId");

                    b.ToTable("Entitys");
                });

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("EmailTo");

                    b.Property<decimal>("GrandTotal");

                    b.Property<bool>("InvoiceEmailed");

                    b.Property<int>("InvoiceNo");

                    b.Property<string>("Notes");

                    b.Property<string>("OrderedBy");

                    b.Property<double>("PaidAmount");

                    b.Property<DateTime>("PaidDate");

                    b.Property<double>("PaidTax");

                    b.Property<string>("PaymentDetails");

                    b.Property<string>("PurchaseOrderRef");

                    b.Property<int>("Status");

                    b.Property<decimal>("SubTotal");

                    b.Property<decimal>("TaxTotal");

                    b.Property<string>("TermsAndConditions");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.InvoiceLine", b =>
                {
                    b.Property<int>("InvoiceLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InvoiceId");

                    b.Property<decimal>("LineTotal");

                    b.Property<string>("Notes");

                    b.Property<string>("Product");

                    b.Property<string>("ProductCode");

                    b.Property<double>("Quantity");

                    b.Property<decimal>("SubTotal");

                    b.Property<bool>("TaxExempt");

                    b.Property<decimal>("TaxTotal");

                    b.Property<decimal>("UnitCost");

                    b.HasKey("InvoiceLineId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceLines");
                });

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.Customer", b =>
                {
                    b.HasOne("SilverdawnSoftware.Invoice.Database.Entity", "Entity")
                        .WithMany("Customers")
                        .HasForeignKey("EntityId");

                    b.OwnsOne("SilverdawnSoftware.Invoice.Database.Address", "Address", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("AddresLine2");

                            b1.Property<string>("AddressExternalRef");

                            b1.Property<string>("AddressLine1");

                            b1.Property<string>("AddressLine3");

                            b1.Property<string>("City");

                            b1.Property<string>("Country");

                            b1.Property<string>("PostZipCode");

                            b1.Property<string>("StateCounty");

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customers");

                            b1.HasOne("SilverdawnSoftware.Invoice.Database.Customer")
                                .WithOne("Address")
                                .HasForeignKey("SilverdawnSoftware.Invoice.Database.Address", "CustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.Entity", b =>
                {
                    b.OwnsOne("SilverdawnSoftware.Invoice.Database.Address", "Address", b1 =>
                        {
                            b1.Property<int>("EntityId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("AddresLine2");

                            b1.Property<string>("AddressExternalRef");

                            b1.Property<string>("AddressLine1");

                            b1.Property<string>("AddressLine3");

                            b1.Property<string>("City");

                            b1.Property<string>("Country");

                            b1.Property<string>("PostZipCode");

                            b1.Property<string>("StateCounty");

                            b1.HasKey("EntityId");

                            b1.ToTable("Entitys");

                            b1.HasOne("SilverdawnSoftware.Invoice.Database.Entity")
                                .WithOne("Address")
                                .HasForeignKey("SilverdawnSoftware.Invoice.Database.Address", "EntityId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.Invoice", b =>
                {
                    b.HasOne("SilverdawnSoftware.Invoice.Database.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId");

                    b.OwnsOne("SilverdawnSoftware.Invoice.Database.Address", "BillingAddress", b1 =>
                        {
                            b1.Property<int>("InvoiceId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("AddresLine2");

                            b1.Property<string>("AddressExternalRef");

                            b1.Property<string>("AddressLine1");

                            b1.Property<string>("AddressLine3");

                            b1.Property<string>("City");

                            b1.Property<string>("Country");

                            b1.Property<string>("PostZipCode");

                            b1.Property<string>("StateCounty");

                            b1.HasKey("InvoiceId");

                            b1.ToTable("Invoices");

                            b1.HasOne("SilverdawnSoftware.Invoice.Database.Invoice")
                                .WithOne("BillingAddress")
                                .HasForeignKey("SilverdawnSoftware.Invoice.Database.Address", "InvoiceId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("SilverdawnSoftware.Invoice.Database.Address", "ShippingAddress", b1 =>
                        {
                            b1.Property<int>("InvoiceId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("AddresLine2");

                            b1.Property<string>("AddressExternalRef");

                            b1.Property<string>("AddressLine1");

                            b1.Property<string>("AddressLine3");

                            b1.Property<string>("City");

                            b1.Property<string>("Country");

                            b1.Property<string>("PostZipCode");

                            b1.Property<string>("StateCounty");

                            b1.HasKey("InvoiceId");

                            b1.ToTable("Invoices");

                            b1.HasOne("SilverdawnSoftware.Invoice.Database.Invoice")
                                .WithOne("ShippingAddress")
                                .HasForeignKey("SilverdawnSoftware.Invoice.Database.Address", "InvoiceId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("SilverdawnSoftware.Invoice.Database.InvoiceLine", b =>
                {
                    b.HasOne("SilverdawnSoftware.Invoice.Database.Invoice", "Invoice")
                        .WithMany("InvoiceLines")
                        .HasForeignKey("InvoiceId");
                });
#pragma warning restore 612, 618
        }
    }
}
