﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Olympic_Games_Data_Transfer.Models;

#nullable disable

namespace Olympic_Games_Data_Transfer.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Olympic_Games_Data_Transfer.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("flag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.HasIndex("EventID");

                    b.HasIndex("SportID");

                    b.ToTable("Countrys");

                    b.HasData(
                        new
                        {
                            CountryID = "canada",
                            CountryName = "Canada",
                            EventID = "winter olympics",
                            SportID = "curling",
                            flag = "canada.png"
                        },
                        new
                        {
                            CountryID = "sweden",
                            CountryName = "Sweden",
                            EventID = "winter olympics",
                            SportID = "curling",
                            flag = "sweden.png"
                        },
                        new
                        {
                            CountryID = "britain",
                            CountryName = "Great Britain",
                            EventID = "winter olympics",
                            SportID = "curling",
                            flag = "britain.png"
                        },
                        new
                        {
                            CountryID = "jamaica",
                            CountryName = "Jamaica",
                            EventID = "winter olympics",
                            SportID = "bobsleigh",
                            flag = "jamaica.png"
                        },
                        new
                        {
                            CountryID = "italy",
                            CountryName = "Italy",
                            EventID = "winter olympics",
                            SportID = "bobsleigh",
                            flag = "italy.png"
                        },
                        new
                        {
                            CountryID = "japan",
                            CountryName = "Japan",
                            EventID = "winter olympics",
                            SportID = "bobsleigh",
                            flag = "japan.png"
                        },
                        new
                        {
                            CountryID = "germany",
                            CountryName = "Germany",
                            EventID = "summer olympics",
                            SportID = "diving",
                            flag = "germany.png"
                        },
                        new
                        {
                            CountryID = "china",
                            CountryName = "China",
                            EventID = "summer olympics",
                            SportID = "diving",
                            flag = "china.png"
                        },
                        new
                        {
                            CountryID = "mexico",
                            CountryName = "Mexico",
                            EventID = "summer olympics",
                            SportID = "diving",
                            flag = "mexico.png"
                        },
                        new
                        {
                            CountryID = "brazil",
                            CountryName = "Brazil",
                            EventID = "summer olympics",
                            SportID = "cycling",
                            flag = "brazil.png"
                        },
                        new
                        {
                            CountryID = "netherlands",
                            CountryName = "Netherlands",
                            EventID = "summer olympics",
                            SportID = "cycling",
                            flag = "netherlands.png"
                        },
                        new
                        {
                            CountryID = "usa",
                            CountryName = "USA",
                            EventID = "summer olympics",
                            SportID = "cycling",
                            flag = "usa.png"
                        },
                        new
                        {
                            CountryID = "thailand",
                            CountryName = "Thailand",
                            EventID = "paralympics",
                            SportID = "archery",
                            flag = "thailand.png"
                        },
                        new
                        {
                            CountryID = "uruguay",
                            CountryName = "Uruguay",
                            EventID = "paralympics",
                            SportID = "archery",
                            flag = "uruguay.png"
                        },
                        new
                        {
                            CountryID = "ukraine",
                            CountryName = "Ukraine",
                            EventID = "paralympics",
                            SportID = "archery",
                            flag = "ukraine.png"
                        },
                        new
                        {
                            CountryID = "austria",
                            CountryName = "Austria",
                            EventID = "paralympics",
                            SportID = "canoe sprint",
                            flag = "austria.png"
                        },
                        new
                        {
                            CountryID = "pakistan",
                            CountryName = "Pakistan",
                            EventID = "paralympics",
                            SportID = "canoe sprint",
                            flag = "pakistan.png"
                        },
                        new
                        {
                            CountryID = "zimbabwe",
                            CountryName = "Zimbabwe",
                            EventID = "paralympics",
                            SportID = "canoe sprint",
                            flag = "zimbabwe.png"
                        },
                        new
                        {
                            CountryID = "france",
                            CountryName = "France",
                            EventID = "youth olympics",
                            SportID = "breakdancing",
                            flag = "france.png"
                        },
                        new
                        {
                            CountryID = "cyprus",
                            CountryName = "Cyprus",
                            EventID = "youth olympics",
                            SportID = "breakdancing",
                            flag = "cyprus.png"
                        },
                        new
                        {
                            CountryID = "russia",
                            CountryName = "Russia",
                            EventID = "youth olympics",
                            SportID = "breakdancing",
                            flag = "russia.png"
                        },
                        new
                        {
                            CountryID = "finland",
                            CountryName = "Finland",
                            EventID = "youth olympics",
                            SportID = "skatebording",
                            flag = "finland.png"
                        },
                        new
                        {
                            CountryID = "slovakia",
                            CountryName = "Slovakia",
                            EventID = "youth olympics",
                            SportID = "skatebording",
                            flag = "slovakia.png"
                        },
                        new
                        {
                            CountryID = "portugal",
                            CountryName = "Portugal",
                            EventID = "youth olympics",
                            SportID = "skatebording",
                            flag = "portugal.png"
                        });
                });

            modelBuilder.Entity("Olympic_Games_Data_Transfer.Models.Event", b =>
                {
                    b.Property<string>("EventID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventID");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventID = "summer olympics",
                            EventName = "Summer Olympics"
                        },
                        new
                        {
                            EventID = "winter olympics",
                            EventName = "Winter Olympics"
                        },
                        new
                        {
                            EventID = "paralympics",
                            EventName = "Paralympic Games"
                        },
                        new
                        {
                            EventID = "youth olympics",
                            EventName = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("Olympic_Games_Data_Transfer.Models.Sport", b =>
                {
                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportID");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportID = "curling",
                            SportName = "Curling",
                            category = "Indoor"
                        },
                        new
                        {
                            SportID = "bobsleigh",
                            SportName = "Bobsleigh",
                            category = "Outdoor"
                        },
                        new
                        {
                            SportID = "diving",
                            SportName = "Diving",
                            category = "Indoor"
                        },
                        new
                        {
                            SportID = "cycling",
                            SportName = "Cycling",
                            category = "Outdoor"
                        },
                        new
                        {
                            SportID = "archery",
                            SportName = "Archery",
                            category = "Indoor"
                        },
                        new
                        {
                            SportID = "canoe sprint",
                            SportName = "Canoe Sprint",
                            category = "Outdoor"
                        },
                        new
                        {
                            SportID = "breakdancing",
                            SportName = "Breakdancing",
                            category = "Indoor"
                        },
                        new
                        {
                            SportID = "skatebording",
                            SportName = "Skatebording",
                            category = "Outdoor"
                        });
                });

            modelBuilder.Entity("Olympic_Games_Data_Transfer.Models.Country", b =>
                {
                    b.HasOne("Olympic_Games_Data_Transfer.Models.Event", "events")
                        .WithMany()
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olympic_Games_Data_Transfer.Models.Sport", "sport")
                        .WithMany()
                        .HasForeignKey("SportID");

                    b.Navigation("events");

                    b.Navigation("sport");
                });
#pragma warning restore 612, 618
        }
    }
}
