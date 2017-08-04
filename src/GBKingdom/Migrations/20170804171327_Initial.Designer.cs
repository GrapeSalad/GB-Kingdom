using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GBKingdom.Models;

namespace GBKingdom.Migrations
{
    [DbContext(typeof(GBKingdomContext))]
    [Migration("20170804171327_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GBKingdom.Models.Gummi", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("cost");

                    b.Property<string>("name");

                    b.Property<string>("originCountry");

                    b.HasKey("id");

                    b.ToTable("Gummies");
                });
        }
    }
}
