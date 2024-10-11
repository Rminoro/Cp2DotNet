﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace CP2.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CP2.Domain.Entities.FornecedorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("NVARCHAR2(18)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("DATE");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("CP2.Domain.Entities.VendedorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("ComissaoPercentual")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("DataContratacao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<decimal>("MetaMensal")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });
#pragma warning restore 612, 618
        }
    }
}
