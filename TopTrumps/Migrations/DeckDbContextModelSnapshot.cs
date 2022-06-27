﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopTrumps.Data;

#nullable disable

namespace TopTrumps.Migrations
{
    [DbContext(typeof(DeckDbContext))]
    partial class DeckDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TopTrumps.Models.Attributes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Attr1")
                        .HasColumnType("int");

                    b.Property<int>("Attr2")
                        .HasColumnType("int");

                    b.Property<int>("Attr3")
                        .HasColumnType("int");

                    b.Property<int>("Attr4")
                        .HasColumnType("int");

                    b.Property<int>("Attr5")
                        .HasColumnType("int");

                    b.Property<int>("Deckid")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Attribute");
                });

            modelBuilder.Entity("TopTrumps.Models.Card", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Attr1")
                        .HasColumnType("int");

                    b.Property<int>("Attr2")
                        .HasColumnType("int");

                    b.Property<int>("Attr3")
                        .HasColumnType("int");

                    b.Property<int>("Attr4")
                        .HasColumnType("int");

                    b.Property<int>("Attr5")
                        .HasColumnType("int");

                    b.Property<int>("Deckid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("TopTrumps.Models.Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deck");
                });
#pragma warning restore 612, 618
        }
    }
}
