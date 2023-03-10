// <auto-generated />
using System;
using DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(CongressContext))]
    [Migration("20230121054128_transportLayover_table_update")]
    partial class transportLayover_table_update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.Concrete.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SurName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Entities.Concrete.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnnounceContent")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("AnnounceDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("AnnounceTitle")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImagePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Entities.Concrete.BankAccountInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BankCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Branch")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("BankAccountInfos");
                });

            modelBuilder.Entity("Entities.Concrete.Congress", b =>
                {
                    b.Property<int>("KongreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BilimKurulu")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImagePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KongreAdi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KongreAdresi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KongreAltKonu")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KongreBaskani")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("KongreBitisTarihi")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("KongreDuzenlemeKurulu")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KongreHakkinda")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KongreKonusu")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("KongreTarihi")
                        .HasColumnType("datetime(6)");

                    b.HasKey("KongreId");

                    b.ToTable("Congresses");
                });

            modelBuilder.Entity("Entities.Concrete.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Message")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NameSurname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entities.Concrete.GeneralInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PaperEvaluation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rules")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SummaryContent")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("GeneralInformations");
                });

            modelBuilder.Entity("Entities.Concrete.Save", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("OralPresentationMemberPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("OralPresentationNonMemberPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ParticipationPriceServiceAdditionDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VideoConferenceDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VideoConferenceMemberPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VideoConferenceNonMemberPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Saves");
                });

            modelBuilder.Entity("Entities.Concrete.TrBankAccountInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccountName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BankName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Iban")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("TrBankAccountInfos");
                });

            modelBuilder.Entity("Entities.Concrete.TransportLayover", b =>
                {
                    b.Property<int>("TransportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Capacity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImagePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MinDemand")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Price")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TransportId");

                    b.ToTable("TransportLayovers");
                });
#pragma warning restore 612, 618
        }
    }
}
