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

                    b.Property<int?>("Hora")
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

                    b.Property<string>("TyM")
                        .HasColumnType("TEXT");

                    b.HasKey("OrdenID");

                    b.ToTable("Emergencia");
                });

            modelBuilder.Entity("DrEmergencias.EmergenciaA", b =>
                {
                    b.Property<int>("OrdenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ARS")
                        .HasColumnType("INTEGER");

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

                    b.Property<int?>("Hora")
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

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenID");

                    b.ToTable("EmergenciaA");
                });

            modelBuilder.Entity("DrEmergencias.Paciente", b =>
                {
                    b.Property<int>("OrdenID")
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

                    b.Property<int?>("EmergenciaAOrdenID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmergenciaOrdenID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("FechadeNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Municipio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ocupacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("PacienteID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Provincia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("sexo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("tutor")
                        .HasColumnType("TEXT");

                    b.HasKey("OrdenID");

                    b.HasIndex("EmergenciaAOrdenID");

                    b.HasIndex("EmergenciaOrdenID");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("DrEmergencias.Paciente", b =>
                {
                    b.HasOne("DrEmergencias.EmergenciaA", null)
                        .WithMany("Paciente")
                        .HasForeignKey("EmergenciaAOrdenID");

                    b.HasOne("DrEmergencias.Emergencia", null)
                        .WithMany("Paciente")
                        .HasForeignKey("EmergenciaOrdenID");
                });

            modelBuilder.Entity("DrEmergencias.Emergencia", b =>
                {
                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("DrEmergencias.EmergenciaA", b =>
                {
                    b.Navigation("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}
