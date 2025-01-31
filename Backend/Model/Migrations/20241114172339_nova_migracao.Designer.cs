﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(TheHouseContext))]
    [Migration("20241114172339_nova_migracao")]
    partial class nova_migracao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Model.Entities.CompraEntities.Mercado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Rua")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Mercado");
                });

            modelBuilder.Entity("Model.Entities.CompraEntity.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataCompra")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LinkNota")
                        .HasColumnType("text");

                    b.Property<int>("ListaCompraId")
                        .HasColumnType("integer");

                    b.Property<int>("MercadoId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ListaCompraId");

                    b.HasIndex("MercadoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("Model.Entities.CompraEntity.ItemListaCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ListaCompraId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<decimal?>("ValorMedioUnitario")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ListaCompraId");

                    b.ToTable("ItemListaCompras");
                });

            modelBuilder.Entity("Model.Entities.CompraEntity.ListaCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ListaCompra");
                });

            modelBuilder.Entity("Model.Entities.Financas.FinancaDespesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SituacaoDespesaEnum")
                        .HasColumnType("integer");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("FinancaDespesa", (string)null);
                });

            modelBuilder.Entity("Model.Entities.Financas.FinancaReceita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("FinancaReceita", (string)null);
                });

            modelBuilder.Entity("Model.Entities.GrupoMeta.Meta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataObjetivo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MetaStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeMeta")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.Property<Guid>("UsuarioId1")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ValorAdquirido")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorTotalMeta")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Metas", (string)null);
                });

            modelBuilder.Entity("Model.Entities.GrupoUsuario.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<int?>("Genero")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int?>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Rua")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Model.Entities.Visita.Visita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataVisita")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("StatusVisita")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Visita", (string)null);
                });

            modelBuilder.Entity("Model.Entities.CompraEntity.Compra", b =>
                {
                    b.HasOne("Model.Entities.CompraEntity.ListaCompra", "ListaCompra")
                        .WithMany()
                        .HasForeignKey("ListaCompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.CompraEntities.Mercado", "Mercado")
                        .WithMany()
                        .HasForeignKey("MercadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.GrupoUsuario.Usuario", "Usuario")
                        .WithMany("Compras")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListaCompra");

                    b.Navigation("Mercado");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Model.Entities.CompraEntity.ItemListaCompra", b =>
                {
                    b.HasOne("Model.Entities.CompraEntity.ListaCompra", "ListaCompra")
                        .WithMany("ItensListaCompras")
                        .HasForeignKey("ListaCompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListaCompra");
                });

            modelBuilder.Entity("Model.Entities.GrupoMeta.Meta", b =>
                {
                    b.HasOne("Model.Entities.GrupoUsuario.Usuario", "Usuario")
                        .WithMany("Metas")
                        .HasForeignKey("UsuarioId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Model.Entities.CompraEntity.ListaCompra", b =>
                {
                    b.Navigation("ItensListaCompras");
                });

            modelBuilder.Entity("Model.Entities.GrupoUsuario.Usuario", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Metas");
                });
#pragma warning restore 612, 618
        }
    }
}
