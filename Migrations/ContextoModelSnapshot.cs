﻿// <auto-generated />
using System;
using DrEmergencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrEmergencias.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("DrEmergencias.Articulo", b =>
                {
                    b.Property<int>("ArticuloID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("ArticuloID");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("DrEmergencias.Emergencia", b =>
                {
                    b.Property<int>("OrdenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Antecedentes")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("AtencionesPrevias")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Coprologico")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Diagnostico")
                        .HasColumnType("TEXT");

                    b.Property<string>("Donde")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergenciaID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Especifique")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Ex_Orina")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FC")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FR")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Glisemia")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Hemogramas")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Imagenes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("M_Consulta")
                        .HasColumnType("TEXT");

                    b.Property<string>("MedicoBase")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Peso")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TA")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Temperatura")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TyM")
                        .HasColumnType("TEXT");

                    b.HasKey("OrdenID");

                    b.ToTable("Emergencias");
                });

            modelBuilder.Entity("DrEmergencias.EmergenciaA", b =>
                {
                    b.Property<int>("OrdenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ARS")
                        .HasColumnType("TEXT");

                    b.Property<string>("Abdomen")
                        .HasColumnType("TEXT");

                    b.Property<string>("Antecedentes")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("AtencionesPrevias")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cabeza")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Coprologico")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Corazon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cuello")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diagnostico")
                        .HasColumnType("TEXT");

                    b.Property<string>("Donde")
                        .HasColumnType("TEXT");

                    b.Property<string>("E_Inferiores")
                        .HasColumnType("TEXT");

                    b.Property<string>("E_Superiores")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergenciaID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Especifique")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Ex_Orina")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FC")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FR")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Glisemia")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Hemogramas")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Imagenes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("M_Consulta")
                        .HasColumnType("TEXT");

                    b.Property<string>("MedicoBase")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NSS")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Peso")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Pulmones")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TA")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Temperatura")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Torax")
                        .HasColumnType("TEXT");

                    b.Property<string>("TyM")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenID");

                    b.ToTable("EmergenciaAs");
                });

            modelBuilder.Entity("DrEmergencias.EmergenciaADetalle", b =>
                {
                    b.Property<int>("ADetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmergenciaAId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PacienteID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ADetalleId");

                    b.HasIndex("PacienteID");

                    b.ToTable("EmergenciaADetalle");
                });

            modelBuilder.Entity("DrEmergencias.EmergenciaDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmergenciaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PacienteID")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("PacienteID");

                    b.ToTable("EmergenciaDetalle");
                });

            modelBuilder.Entity("DrEmergencias.Paciente", b =>
                {
                    b.Property<int>("PacienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alergia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("CedulaTutor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FechadeNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Municipio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ocupacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Provincia")
                        .HasColumnType("TEXT");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tutor")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("PacienteID");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("DrEmergencias.Suplidor", b =>
                {
                    b.Property<int>("SuplidorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SuplidorID");

                    b.ToTable("Suplidores");
                });

            modelBuilder.Entity("OrdenInventario", b =>
                {
                    b.Property<int>("OrdenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticuloID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Razon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("OrdenID");

                    b.ToTable("OrdenInventario");
                });

            modelBuilder.Entity("DrEmergencias.EmergenciaADetalle", b =>
                {
                    b.HasOne("DrEmergencias.Paciente", null)
                        .WithMany("DetalleAseguradas")
                        .HasForeignKey("PacienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrEmergencias.EmergenciaDetalle", b =>
                {
                    b.HasOne("DrEmergencias.Paciente", null)
                        .WithMany("DetalleNoAseguradas")
                        .HasForeignKey("PacienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrEmergencias.Paciente", b =>
                {
                    b.Navigation("DetalleAseguradas");

                    b.Navigation("DetalleNoAseguradas");
                });
#pragma warning restore 612, 618
        }
    }
}
