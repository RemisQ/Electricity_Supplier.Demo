// <auto-generated />
using System;
using Electricity_Supplier.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Electricity_Supplier.DataAccess.Migrations
{
    [DbContext(typeof(ElectricitySupplierDbContext))]
    partial class ElectricitySupplierDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ObjectAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjectNumber")
                        .HasColumnType("int");

                    b.Property<int?>("PointOfSaleId")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SalesManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PointOfSaleId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesManagerId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SalesManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SalesManagerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.PointOfSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PointOfSales");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DurationByMonths")
                        .HasColumnType("int");

                    b.Property<decimal>("KWhPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeZone")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.SalesManager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PointOfSaleId")
                        .HasColumnType("int");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PointOfSaleId");

                    b.ToTable("SalesManagers");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.Contract", b =>
                {
                    b.HasOne("Electricity_Supplier.DataAccess.Entities.Customer", "Customer")
                        .WithMany("Contracts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Electricity_Supplier.DataAccess.Entities.PointOfSale", null)
                        .WithMany("Contracts")
                        .HasForeignKey("PointOfSaleId");

                    b.HasOne("Electricity_Supplier.DataAccess.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Electricity_Supplier.DataAccess.Entities.SalesManager", null)
                        .WithMany("Contracts")
                        .HasForeignKey("SalesManagerId");

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.Customer", b =>
                {
                    b.HasOne("Electricity_Supplier.DataAccess.Entities.SalesManager", "SalesManager")
                        .WithMany("Customers")
                        .HasForeignKey("SalesManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalesManager");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.SalesManager", b =>
                {
                    b.HasOne("Electricity_Supplier.DataAccess.Entities.PointOfSale", "PointOfSale")
                        .WithMany("SalesManagers")
                        .HasForeignKey("PointOfSaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PointOfSale");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.Customer", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.PointOfSale", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("SalesManagers");
                });

            modelBuilder.Entity("Electricity_Supplier.DataAccess.Entities.SalesManager", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
