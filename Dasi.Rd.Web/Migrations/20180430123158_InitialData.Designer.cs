﻿// <auto-generated />
using Dasi.Rd.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Dasi.Rd.Web.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180430123158_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dasi.Rd.Data.Entities.Fitandremana", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateEdition");

                    b.Property<string>("FitandremanaAdress");

                    b.Property<string>("FitandremanaName");

                    b.Property<int?>("SynodaID");

                    b.HasKey("ID");

                    b.HasIndex("SynodaID");

                    b.ToTable("Fitandremana");
                });

            modelBuilder.Entity("Dasi.Rd.Data.Entities.Synoda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateEdition");

                    b.Property<string>("SynodaName");

                    b.Property<int>("SynodaNumber");

                    b.HasKey("ID");

                    b.ToTable("Synoda");
                });

            modelBuilder.Entity("Dasi.Rd.Data.Entities.Fitandremana", b =>
                {
                    b.HasOne("Dasi.Rd.Data.Entities.Synoda", "Synoda")
                        .WithMany("Fitandremanas")
                        .HasForeignKey("SynodaID");
                });
#pragma warning restore 612, 618
        }
    }
}