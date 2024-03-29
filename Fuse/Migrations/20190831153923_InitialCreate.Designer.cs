﻿// <auto-generated />
using System;
using Fuse.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fuse.Migrations
{
    [DbContext(typeof(FuseContext))]
    [Migration("20190831153923_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Fuse.Model.Costumer", b =>
                {
                    b.Property<int>("IdCostumer")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("NbrArticle");

                    b.HasKey("IdCostumer");

                    b.ToTable("Costumer");
                });
#pragma warning restore 612, 618
        }
    }
}
