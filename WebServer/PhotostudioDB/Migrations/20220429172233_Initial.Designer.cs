﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PhotostudioDB;

#nullable disable

namespace PhotostudioDB.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220429172233_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PhotostudioDB.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("text")
                        .HasColumnName("apartment_number");

                    b.Property<string>("Building")
                        .HasColumnType("text")
                        .HasColumnName("building");

                    b.Property<string>("Entrance")
                        .HasColumnType("text")
                        .HasColumnName("entrance");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("house_number");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("street");

                    b.HasKey("Id");

                    b.ToTable("address", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.AuthToken", b =>
                {
                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<DateTime>("TokenTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Token");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("AuthTokens");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .HasColumnType("text")
                        .HasColumnName("company");

                    b.Property<string>("EMail")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("middle_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)")
                        .HasColumnName("phone");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("integer")
                        .HasColumnName("profile_id");

                    b.HasKey("Id");

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.ToTable("clients", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("integer")
                        .HasColumnName("client_id");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer")
                        .HasColumnName("order_id");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("contracts", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<string>("EMail")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("middle_name");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("passport");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)")
                        .HasColumnName("phone");

                    b.Property<int>("ProfileId")
                        .HasColumnType("integer")
                        .HasColumnName("profile_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("Passport")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer")
                        .HasColumnName("address_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("hall", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("integer")
                        .HasColumnName("client_id");

                    b.Property<int>("ContractId")
                        .HasColumnType("integer")
                        .HasColumnName("contract_id");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_time");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer")
                        .HasColumnName("status_id");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("StatusId");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("login");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("pass");

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("profiles", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.RentedItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("money")
                        .HasColumnName("cost");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsKids")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_kids");

                    b.Property<bool>("IsСlothes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_clothes");

                    b.Property<long>("Number")
                        .HasColumnType("bigint")
                        .HasColumnName("number");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("rented_items", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Cost")
                        .HasColumnType("money")
                        .HasColumnName("cost");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("services", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.ApplicationService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer")
                        .HasColumnName("order_id");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer")
                        .HasColumnName("service_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer")
                        .HasColumnName("status_id");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("StatusId");

                    b.ToTable("application_service", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationService");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("statuses", (string)null);
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.HallRentService", b =>
                {
                    b.HasBaseType("PhotostudioDB.Models.Services.ApplicationService");

                    b.Property<int>("Duration")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("integer")
                        .HasColumnName("duration");

                    b.Property<int>("HallId")
                        .HasColumnType("integer")
                        .HasColumnName("hall_id");

                    b.Property<DateTime>("StartDateTime")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_date_time");

                    b.HasIndex("HallId");

                    b.ToTable("application_service", (string)null);

                    b.HasDiscriminator().HasValue("HallRentService");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.PhotoVideoService", b =>
                {
                    b.HasBaseType("PhotostudioDB.Models.Services.ApplicationService");

                    b.Property<int>("AddressId")
                        .HasColumnType("integer")
                        .HasColumnName("address_id");

                    b.Property<int>("Duration")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("integer")
                        .HasColumnName("duration");

                    b.Property<DateTime>("StartDateTime")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_date_time");

                    b.HasIndex("AddressId");

                    b.ToTable("application_service", (string)null);

                    b.HasDiscriminator().HasValue("PhotoVideoService");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.RentService", b =>
                {
                    b.HasBaseType("PhotostudioDB.Models.Services.ApplicationService");

                    b.Property<int>("Duration")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("integer")
                        .HasColumnName("duration");

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasColumnName("number");

                    b.Property<int>("RentedItemId")
                        .HasColumnType("integer")
                        .HasColumnName("rented_item_id");

                    b.Property<DateTime>("StartDateTime")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_date_time");

                    b.HasIndex("RentedItemId");

                    b.ToTable("application_service", (string)null);

                    b.HasDiscriminator().HasValue("RentService");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.StyleService", b =>
                {
                    b.HasBaseType("PhotostudioDB.Models.Services.PhotoVideoService");

                    b.Property<bool>("IsFullTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_full_time");

                    b.ToTable("application_service", (string)null);

                    b.HasDiscriminator().HasValue("StyleService");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Client", b =>
                {
                    b.HasOne("PhotostudioDB.Models.Profile", "Profile")
                        .WithOne("Client")
                        .HasForeignKey("PhotostudioDB.Models.Client", "ProfileId");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Contract", b =>
                {
                    b.HasOne("PhotostudioDB.Models.Client", "Client")
                        .WithMany("Contracts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhotostudioDB.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhotostudioDB.Models.Order", "Order")
                        .WithOne("Contract")
                        .HasForeignKey("PhotostudioDB.Models.Contract", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Employee", b =>
                {
                    b.HasOne("PhotostudioDB.Models.Profile", "Profile")
                        .WithOne("Employee")
                        .HasForeignKey("PhotostudioDB.Models.Employee", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhotostudioDB.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Hall", b =>
                {
                    b.HasOne("PhotostudioDB.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Order", b =>
                {
                    b.HasOne("PhotostudioDB.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhotostudioDB.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.ApplicationService", b =>
                {
                    b.HasOne("PhotostudioDB.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhotostudioDB.Models.Order", "Order")
                        .WithMany("Services")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhotostudioDB.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhotostudioDB.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Order");

                    b.Navigation("Service");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.HallRentService", b =>
                {
                    b.HasOne("PhotostudioDB.Models.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.PhotoVideoService", b =>
                {
                    b.HasOne("PhotostudioDB.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Services.RentService", b =>
                {
                    b.HasOne("PhotostudioDB.Models.RentedItem", "RentedItem")
                        .WithMany()
                        .HasForeignKey("RentedItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RentedItem");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Client", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Order", b =>
                {
                    b.Navigation("Contract");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("PhotostudioDB.Models.Profile", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
