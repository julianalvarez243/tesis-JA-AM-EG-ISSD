﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using capaEF;

#nullable disable

namespace capaEF.Migrations
{
    [DbContext(typeof(GescomDBContext))]
    partial class GescomDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("capaEntidad.Bebida", b =>
                {
                    b.Property<int>("BebidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BebidaId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BebidaId");

                    b.ToTable("Bebidas");
                });

            modelBuilder.Entity("capaEntidad.Caja", b =>
                {
                    b.Property<int>("CajaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CajaId"));

                    b.Property<decimal>("CantFinal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CantInicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("EstadoCajaId")
                        .HasColumnType("int");

                    b.HasKey("CajaId");

                    b.HasIndex("EstadoCajaId");

                    b.ToTable("Cajas");
                });

            modelBuilder.Entity("capaEntidad.Comanda", b =>
                {
                    b.Property<int>("ComandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComandaId"));

                    b.Property<int?>("BebidaId")
                        .HasColumnType("int");

                    b.Property<int>("CantComensales")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComidaId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoComandaId")
                        .HasColumnType("int");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.HasKey("ComandaId");

                    b.HasIndex("BebidaId");

                    b.HasIndex("ComidaId");

                    b.HasIndex("EstadoComandaId");

                    b.HasIndex("MesaId");

                    b.ToTable("Comandas");
                });

            modelBuilder.Entity("capaEntidad.Comida", b =>
                {
                    b.Property<int>("ComidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComidaId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ComidaId");

                    b.ToTable("Comidas");
                });

            modelBuilder.Entity("capaEntidad.EstadoCaja", b =>
                {
                    b.Property<int>("EstadoCajaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoCajaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoCajaId");

                    b.ToTable("EstadosCaja");
                });

            modelBuilder.Entity("capaEntidad.EstadoComanda", b =>
                {
                    b.Property<int>("EstadoComandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoComandaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoComandaId");

                    b.ToTable("EstadosComanda");
                });

            modelBuilder.Entity("capaEntidad.EstadoMesa", b =>
                {
                    b.Property<int>("EstadoMesaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoMesaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoMesaId");

                    b.ToTable("EstadosMesa");
                });

            modelBuilder.Entity("capaEntidad.EstadoMozo", b =>
                {
                    b.Property<int>("EstadoMozoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoMozoId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoMozoId");

                    b.ToTable("EstadosMozo");
                });

            modelBuilder.Entity("capaEntidad.Factura", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacturaId"));

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MetodoPago")
                        .HasColumnType("int");

                    b.HasKey("FacturaId");

                    b.HasIndex("ComandaId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("capaEntidad.Mesa", b =>
                {
                    b.Property<int>("MesaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MesaId"));

                    b.Property<int>("EstadoMesaId")
                        .HasColumnType("int");

                    b.Property<int?>("MozoId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroMesa")
                        .HasColumnType("int");

                    b.Property<int>("TamanioId")
                        .HasColumnType("int");

                    b.HasKey("MesaId");

                    b.HasIndex("EstadoMesaId");

                    b.HasIndex("MozoId");

                    b.HasIndex("TamanioId");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("capaEntidad.Mozo", b =>
                {
                    b.Property<int>("MozoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MozoId"));

                    b.Property<int>("EstadoMozoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MozoId");

                    b.HasIndex("EstadoMozoId");

                    b.ToTable("Mozos");
                });

            modelBuilder.Entity("capaEntidad.Tamanio", b =>
                {
                    b.Property<int>("TamanioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TamanioId"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TamanioId");

                    b.ToTable("Tamanios");
                });

            modelBuilder.Entity("capaEntidad.Caja", b =>
                {
                    b.HasOne("capaEntidad.EstadoCaja", "EstadoCaja")
                        .WithMany("Cajas")
                        .HasForeignKey("EstadoCajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoCaja");
                });

            modelBuilder.Entity("capaEntidad.Comanda", b =>
                {
                    b.HasOne("capaEntidad.Bebida", "Bebida")
                        .WithMany("Comandas")
                        .HasForeignKey("BebidaId");

                    b.HasOne("capaEntidad.Comida", "Comida")
                        .WithMany("Comandas")
                        .HasForeignKey("ComidaId");

                    b.HasOne("capaEntidad.EstadoComanda", "EstadoComanda")
                        .WithMany("Comandas")
                        .HasForeignKey("EstadoComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("capaEntidad.Mesa", "Mesa")
                        .WithMany("Comandas")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bebida");

                    b.Navigation("Comida");

                    b.Navigation("EstadoComanda");

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("capaEntidad.Factura", b =>
                {
                    b.HasOne("capaEntidad.Comanda", "Comanda")
                        .WithMany()
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");
                });

            modelBuilder.Entity("capaEntidad.Mesa", b =>
                {
                    b.HasOne("capaEntidad.EstadoMesa", "EstadoMesa")
                        .WithMany("Mesas")
                        .HasForeignKey("EstadoMesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("capaEntidad.Mozo", null)
                        .WithMany("Mesas")
                        .HasForeignKey("MozoId");

                    b.HasOne("capaEntidad.Tamanio", "TamanioMesa")
                        .WithMany("Mesas")
                        .HasForeignKey("TamanioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoMesa");

                    b.Navigation("TamanioMesa");
                });

            modelBuilder.Entity("capaEntidad.Mozo", b =>
                {
                    b.HasOne("capaEntidad.EstadoMozo", "EstadoMozo")
                        .WithMany("Mozos")
                        .HasForeignKey("EstadoMozoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoMozo");
                });

            modelBuilder.Entity("capaEntidad.Bebida", b =>
                {
                    b.Navigation("Comandas");
                });

            modelBuilder.Entity("capaEntidad.Comida", b =>
                {
                    b.Navigation("Comandas");
                });

            modelBuilder.Entity("capaEntidad.EstadoCaja", b =>
                {
                    b.Navigation("Cajas");
                });

            modelBuilder.Entity("capaEntidad.EstadoComanda", b =>
                {
                    b.Navigation("Comandas");
                });

            modelBuilder.Entity("capaEntidad.EstadoMesa", b =>
                {
                    b.Navigation("Mesas");
                });

            modelBuilder.Entity("capaEntidad.EstadoMozo", b =>
                {
                    b.Navigation("Mozos");
                });

            modelBuilder.Entity("capaEntidad.Mesa", b =>
                {
                    b.Navigation("Comandas");
                });

            modelBuilder.Entity("capaEntidad.Mozo", b =>
                {
                    b.Navigation("Mesas");
                });

            modelBuilder.Entity("capaEntidad.Tamanio", b =>
                {
                    b.Navigation("Mesas");
                });
#pragma warning restore 612, 618
        }
    }
}
