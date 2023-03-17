﻿// <auto-generated />
using System;
using DrEmergencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrEmergencias.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230316153343_Adding Reorden")]
    partial class AddingReorden
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Num_Reorden")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticuloID");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("DrEmergencias.ComprasDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticuloId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.Property<int>("cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<double>("costo")
                        .HasColumnType("REAL");

                    b.HasKey("DetalleId");

                    b.HasIndex("CompraId");

                    b.ToTable("ComprasDetalle");
                });

            modelBuilder.Entity("DrEmergencias.Emergencia", b =>
                {
                    b.Property<int>("OrdenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Antecedentes")
                        .HasColumnType("TEXT");

                    b.Property<string>("AtencionesPrevias")
                        .HasColumnType("TEXT");

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

                    b.Property<int>("PacienteID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Peso")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TA")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Temperatura")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TyM")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

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

                    b.Property<string>("AtencionesPrevias")
                        .HasColumnType("TEXT");

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

                    b.Property<string>("NSS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PacienteID")
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

                    b.ToTable("EmergenciaAs");
                });

            modelBuilder.Entity("DrEmergencias.Entrada", b =>
                {
                    b.Property<int>("OrdenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticuloID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Razon")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("cantidad_anterior")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenID");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("DrEmergencias.OrdenCompras", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompraId");

                    b.ToTable("OrdenCompras");
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

                    b.HasData(
                        new
                        {
                            PacienteID = 1,
                            Cedula = "809-7877890-1",
                            Direccion = "Nagua,RD",
                            Edad = 19,
                            FechadeNacimiento = "3/8/2003",
                            Municipio = "Nagua",
                            Ocupacion = "DBA",
                            PrimerApellido = "Reynoso",
                            PrimerNombre = "Cesar",
                            Provincia = "MTS",
                            SegundoNombre = "Jose",
                            Sexo = "Hombre",
                            Telefono = "829-567-9072",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 2,
                            Cedula = "222-3377890-3",
                            Direccion = "Pinia 3",
                            Edad = 17,
                            FechadeNacimiento = "3/8/2005",
                            Municipio = "SFM",
                            Ocupacion = "Agricultor",
                            PrimerApellido = "Sanchez",
                            PrimerNombre = "Em",
                            Provincia = "Duarte",
                            SegundoNombre = "Ramon",
                            Sexo = "Hombre",
                            Telefono = "849-343-0000",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 3,
                            Cedula = "332-4447822-2",
                            Direccion = "SALCEDO, LAS cuevas",
                            Edad = 23,
                            FechadeNacimiento = "3/8/2000",
                            Municipio = "Salcedo",
                            Ocupacion = "Estilista",
                            PrimerApellido = "Almonte",
                            PrimerNombre = "Camila",
                            Provincia = "Duarte",
                            SegundoApellido = "Castellanos",
                            SegundoNombre = "",
                            Sexo = "Mujer",
                            Telefono = "787-567-9072",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 4,
                            Cedula = "402-7877890-1",
                            Direccion = "Cabrera, La entrada",
                            Edad = 33,
                            FechadeNacimiento = "3/8/1990",
                            Municipio = "Cabrera",
                            Ocupacion = "Civil Engenieer",
                            PrimerApellido = "Rodriguez",
                            PrimerNombre = "Kinsgton",
                            Provincia = "MTS",
                            SegundoNombre = "Elsmon",
                            Sexo = "Hombre",
                            Telefono = "829-337-9712",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 5,
                            Cedula = "888-7899890-1",
                            Direccion = "Spain, MALLORCA",
                            Edad = 26,
                            FechadeNacimiento = "3/8/1997",
                            Municipio = "N",
                            Ocupacion = "Analista de sistemas",
                            PrimerApellido = "Lopez",
                            PrimerNombre = "Jeison",
                            Provincia = "N",
                            SegundoApellido = "Javier",
                            SegundoNombre = "Lo",
                            Sexo = "Hombre",
                            Telefono = "829-567-7777",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 6,
                            Cedula = "867-1877111-1",
                            Direccion = "USA, CANADA",
                            Edad = 20,
                            FechadeNacimiento = "3/8/2002",
                            Municipio = "N",
                            Ocupacion = "Enterprise ADMIN",
                            PrimerApellido = "JULIENS",
                            PrimerNombre = "Yoland",
                            Provincia = "N",
                            SegundoNombre = "Ves",
                            Sexo = "Mujer",
                            Telefono = "829-567-8890",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 7,
                            Cedula = "222-1111111-1",
                            Direccion = "France, Paris",
                            Edad = 18,
                            FechadeNacimiento = "3/8/2004",
                            Municipio = "N",
                            Ocupacion = "Senior Dev",
                            PrimerApellido = "Estrella",
                            PrimerNombre = "Holland",
                            Provincia = "N",
                            SegundoNombre = "Gab",
                            Sexo = "Hombre",
                            Telefono = "878-567-9072",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 8,
                            Cedula = "666-7877890-1",
                            Direccion = "Nagua,RD",
                            Edad = 19,
                            FechadeNacimiento = "3/8/2003",
                            Municipio = "Nagua",
                            Ocupacion = "Alquimista",
                            PrimerApellido = "Martinez",
                            PrimerNombre = "Nou",
                            Provincia = "MTS",
                            SegundoNombre = "ester",
                            Sexo = "Mujer",
                            Telefono = "829-567-333",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 9,
                            Cedula = "123-7877890-1",
                            Direccion = "Nagua,RD",
                            Edad = 19,
                            FechadeNacimiento = "3/8/2003",
                            Municipio = "Nagua",
                            Ocupacion = "Dto",
                            PrimerApellido = "Ilstens",
                            PrimerNombre = "C",
                            Provincia = "MTS",
                            SegundoNombre = "James",
                            Sexo = "Hombre",
                            Telefono = "119-227-3372",
                            Visible = true
                        },
                        new
                        {
                            PacienteID = 10,
                            Cedula = "804-4877890-4",
                            Direccion = "Nagua,RD",
                            Edad = 19,
                            FechadeNacimiento = "3/8/2003",
                            Municipio = "Nagua",
                            Ocupacion = "DBA",
                            PrimerApellido = "Fernandez",
                            PrimerNombre = "Amanda",
                            Provincia = "MTS",
                            SegundoNombre = "",
                            Sexo = "Mujer",
                            Telefono = "829-567-4444",
                            Visible = true
                        });
                });

            modelBuilder.Entity("DrEmergencias.Salida", b =>
                {
                    b.Property<int>("OrdenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticuloID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Razon")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("cantidad_anterior")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenID");

                    b.ToTable("Salidas");
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

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("SuplidorID");

                    b.ToTable("Suplidores");

                    b.HasData(
                        new
                        {
                            SuplidorID = 1,
                            Contacto = "829-787-5366",
                            Nombre = "GBC Enterprise",
                            Visible = true
                        },
                        new
                        {
                            SuplidorID = 2,
                            Contacto = "809-123-9933",
                            Nombre = "FarmaSalud",
                            Visible = true
                        },
                        new
                        {
                            SuplidorID = 3,
                            Contacto = "829-863-5107",
                            Nombre = "Minoxidil",
                            Visible = true
                        });
                });

            modelBuilder.Entity("DrEmergencias.ComprasDetalle", b =>
                {
                    b.HasOne("DrEmergencias.OrdenCompras", null)
                        .WithMany("Detalle")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrEmergencias.OrdenCompras", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
