﻿// <auto-generated />
using System;
using LanchesMac.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LanchesMac.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230126141134_PedidoDetalhes")]
    partial class PedidoDetalhes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LanchesMac.Models.CarrinhoCompraItem", b =>
                {
                    b.Property<int>("CarrinhoCompraItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("CarrinhoCompraId")
                        .HasColumnType("char(36)");

                    b.Property<int>("LancheId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("CarrinhoCompraItemId");

                    b.HasIndex("LancheId");

                    b.ToTable("CarrinhoCompraItens");
                });

            modelBuilder.Entity("LanchesMac.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("EditedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EditedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "anche feito com ingredientes normais",
                            EditedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Normal"
                        },
                        new
                        {
                            CategoriaId = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Lanche feito com ingredientes integrais e naturais",
                            EditedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Natural"
                        });
                });

            modelBuilder.Entity("LanchesMac.Models.Lanche", b =>
                {
                    b.Property<int>("LancheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("DescricaoLonga")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("EditedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EditedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EmEstoque")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImagemThumbnailUrl")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ImagemUrl")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("LanchePreferido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("LancheId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Lanches");

                    b.HasData(
                        new
                        {
                            LancheId = 1,
                            CategoriaId = 1,
                            CreatedBy = "teste",
                            CreatedOn = new DateTime(2023, 1, 26, 11, 11, 33, 425, DateTimeKind.Local).AddTicks(7818),
                            DescricaoCurta = "Pão, Hamburger, ovo, presunto, queijo e batata palha",
                            DescricaoLonga = "Delicioso hamburger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha",
                            EditedBy = "teste",
                            EditedOn = new DateTime(2023, 1, 26, 11, 11, 33, 425, DateTimeKind.Local).AddTicks(7842),
                            EmEstoque = true,
                            ImagemUrl = "~/imagens/produtos/cheesesalada1.jpg",
                            LanchePreferido = false,
                            Nome = "Cheese Salada",
                            Preco = 12.50m
                        },
                        new
                        {
                            LancheId = 2,
                            CategoriaId = 1,
                            CreatedBy = "teste",
                            CreatedOn = new DateTime(2023, 1, 26, 11, 11, 33, 425, DateTimeKind.Local).AddTicks(7849),
                            DescricaoCurta = "Pão, presunto, mussarela e tomate",
                            DescricaoLonga = "Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho",
                            EditedBy = "teste",
                            EditedOn = new DateTime(2023, 1, 26, 11, 11, 33, 425, DateTimeKind.Local).AddTicks(7852),
                            EmEstoque = true,
                            ImagemUrl = "~/imagens/produtos/mistoquente4.jpg",
                            LanchePreferido = false,
                            Nome = "Misto Quente",
                            Preco = 8.0m
                        },
                        new
                        {
                            LancheId = 3,
                            CategoriaId = 1,
                            CreatedBy = "teste",
                            CreatedOn = new DateTime(2023, 1, 26, 11, 11, 33, 425, DateTimeKind.Local).AddTicks(7857),
                            DescricaoCurta = "Pão, hambúrger, presunto, mussarela e batalha palha",
                            DescricaoLonga = "Pão de hambúrger especial com hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha",
                            EditedBy = "teste",
                            EditedOn = new DateTime(2023, 1, 26, 11, 11, 33, 425, DateTimeKind.Local).AddTicks(7859),
                            EmEstoque = true,
                            ImagemUrl = "~/imagens/produtos/cheeseburger1.jpg",
                            LanchePreferido = false,
                            Nome = "Cheese Burger",
                            Preco = 11.0m
                        },
                        new
                        {
                            LancheId = 4,
                            CategoriaId = 2,
                            CreatedBy = "teste",
                            CreatedOn = new DateTime(2023, 1, 26, 11, 11, 33, 425, DateTimeKind.Local).AddTicks(7864),
                            DescricaoCurta = "Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte",
                            DescricaoLonga = "Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural",
                            EditedBy = "teste",
                            EditedOn = new DateTime(2023, 1, 26, 11, 11, 33, 425, DateTimeKind.Local).AddTicks(7867),
                            EmEstoque = true,
                            ImagemUrl = "~/imagens/produtos/lanchenatural.jpg",
                            LanchePreferido = true,
                            Nome = "anche Natural Peito Peru",
                            Preco = 15.0m
                        });
                });

            modelBuilder.Entity("LanchesMac.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Endereco1")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Endereco2")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("PedidoEntregueEm")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PedidoEnviado")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("PedidoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<int>("TotalItensPedido")
                        .HasColumnType("int");

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("LanchesMac.Models.PedidoDetalhe", b =>
                {
                    b.Property<int>("PedidoDetalheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LancheId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("PedidoDetalheId");

                    b.HasIndex("LancheId");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidoDetalhes");
                });

            modelBuilder.Entity("LanchesMac.Models.CarrinhoCompraItem", b =>
                {
                    b.HasOne("LanchesMac.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lanche");
                });

            modelBuilder.Entity("LanchesMac.Models.Lanche", b =>
                {
                    b.HasOne("LanchesMac.Models.Categoria", "Categoria")
                        .WithMany("Lanches")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("LanchesMac.Models.PedidoDetalhe", b =>
                {
                    b.HasOne("LanchesMac.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanchesMac.Models.Pedido", "Pedido")
                        .WithMany("PedidoItens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lanche");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("LanchesMac.Models.Categoria", b =>
                {
                    b.Navigation("Lanches");
                });

            modelBuilder.Entity("LanchesMac.Models.Pedido", b =>
                {
                    b.Navigation("PedidoItens");
                });
#pragma warning restore 612, 618
        }
    }
}
