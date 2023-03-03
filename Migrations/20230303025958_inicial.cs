using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrEmergencias.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    ArticuloID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Costo = table.Column<double>(type: "REAL", nullable: true),
                    Precio = table.Column<double>(type: "REAL", nullable: true),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: true),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.ArticuloID);
                });

            migrationBuilder.CreateTable(
                name: "EmergenciaAs",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmergenciaID = table.Column<string>(type: "TEXT", nullable: true),
                    PacienteID = table.Column<int>(type: "INTEGER", nullable: false),
                    ARS = table.Column<string>(type: "TEXT", nullable: true),
                    NSS = table.Column<int>(type: "INTEGER", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MConsulta = table.Column<string>(name: "M_Consulta", type: "TEXT", nullable: true),
                    Antecedentes = table.Column<string>(type: "TEXT", nullable: true),
                    AtencionesPrevias = table.Column<string>(type: "TEXT", nullable: true),
                    Donde = table.Column<string>(type: "TEXT", nullable: true),
                    MedicoBase = table.Column<string>(type: "TEXT", nullable: true),
                    Peso = table.Column<int>(type: "INTEGER", nullable: true),
                    TA = table.Column<int>(type: "INTEGER", nullable: true),
                    FC = table.Column<int>(type: "INTEGER", nullable: true),
                    FR = table.Column<int>(type: "INTEGER", nullable: true),
                    Temperatura = table.Column<int>(type: "INTEGER", nullable: true),
                    Cabeza = table.Column<string>(type: "TEXT", nullable: true),
                    Cuello = table.Column<string>(type: "TEXT", nullable: true),
                    Torax = table.Column<string>(type: "TEXT", nullable: true),
                    Pulmones = table.Column<string>(type: "TEXT", nullable: true),
                    Corazon = table.Column<string>(type: "TEXT", nullable: true),
                    Abdomen = table.Column<string>(type: "TEXT", nullable: true),
                    EInferiores = table.Column<string>(name: "E_Inferiores", type: "TEXT", nullable: true),
                    ESuperiores = table.Column<string>(name: "E_Superiores", type: "TEXT", nullable: true),
                    Diagnostico = table.Column<string>(type: "TEXT", nullable: true),
                    Hemogramas = table.Column<int>(type: "INTEGER", nullable: true),
                    ExOrina = table.Column<int>(name: "Ex_Orina", type: "INTEGER", nullable: true),
                    Glisemia = table.Column<int>(type: "INTEGER", nullable: true),
                    Coprologico = table.Column<int>(type: "INTEGER", nullable: true),
                    Imagenes = table.Column<int>(type: "INTEGER", nullable: true),
                    Especifique = table.Column<string>(type: "TEXT", nullable: true),
                    TyM = table.Column<string>(type: "TEXT", nullable: true),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergenciaAs", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Emergencias",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmergenciaID = table.Column<string>(type: "TEXT", nullable: true),
                    PacienteID = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MConsulta = table.Column<string>(name: "M_Consulta", type: "TEXT", nullable: true),
                    Antecedentes = table.Column<string>(type: "TEXT", nullable: true),
                    AtencionesPrevias = table.Column<string>(type: "TEXT", nullable: true),
                    Donde = table.Column<string>(type: "TEXT", nullable: true),
                    MedicoBase = table.Column<string>(type: "TEXT", nullable: true),
                    Peso = table.Column<int>(type: "INTEGER", nullable: true),
                    TA = table.Column<int>(type: "INTEGER", nullable: true),
                    FC = table.Column<int>(type: "INTEGER", nullable: true),
                    FR = table.Column<int>(type: "INTEGER", nullable: true),
                    Temperatura = table.Column<int>(type: "INTEGER", nullable: true),
                    Diagnostico = table.Column<string>(type: "TEXT", nullable: true),
                    Hemogramas = table.Column<int>(type: "INTEGER", nullable: true),
                    ExOrina = table.Column<int>(name: "Ex_Orina", type: "INTEGER", nullable: true),
                    Glisemia = table.Column<int>(type: "INTEGER", nullable: true),
                    Coprologico = table.Column<int>(type: "INTEGER", nullable: true),
                    Imagenes = table.Column<int>(type: "INTEGER", nullable: true),
                    Especifique = table.Column<string>(type: "TEXT", nullable: true),
                    TyM = table.Column<string>(type: "TEXT", nullable: true),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencias", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticuloID = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: true),
                    Razon = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrimerNombre = table.Column<string>(type: "TEXT", nullable: true),
                    SegundoNombre = table.Column<string>(type: "TEXT", nullable: true),
                    PrimerApellido = table.Column<string>(type: "TEXT", nullable: true),
                    SegundoApellido = table.Column<string>(type: "TEXT", nullable: true),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Ocupacion = table.Column<string>(type: "TEXT", nullable: true),
                    Tutor = table.Column<string>(type: "TEXT", nullable: true),
                    CedulaTutor = table.Column<string>(type: "TEXT", nullable: true),
                    Alergia = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    FechadeNacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Edad = table.Column<int>(type: "INTEGER", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Provincia = table.Column<string>(type: "TEXT", nullable: true),
                    Municipio = table.Column<string>(type: "TEXT", nullable: true),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteID);
                });

            migrationBuilder.CreateTable(
                name: "Salidas",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticuloID = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: true),
                    Razon = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salidas", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Suplidores",
                columns: table => new
                {
                    SuplidorID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Contacto = table.Column<string>(type: "TEXT", nullable: false),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplidores", x => x.SuplidorID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "EmergenciaAs");

            migrationBuilder.DropTable(
                name: "Emergencias");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Salidas");

            migrationBuilder.DropTable(
                name: "Suplidores");
        }
    }
}
