using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrEmergencias.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emergencia",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmergenciaID = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Hora = table.Column<int>(type: "INTEGER", nullable: false),
                    MConsulta = table.Column<string>(name: "M_Consulta", type: "TEXT", nullable: false),
                    Antecedentes = table.Column<string>(type: "TEXT", nullable: false),
                    AtencionesPrevias = table.Column<bool>(type: "INTEGER", nullable: false),
                    Donde = table.Column<string>(type: "TEXT", nullable: false),
                    MedicoBase = table.Column<string>(type: "TEXT", nullable: false),
                    Peso = table.Column<int>(type: "INTEGER", nullable: false),
                    TA = table.Column<int>(type: "INTEGER", nullable: false),
                    FC = table.Column<int>(type: "INTEGER", nullable: false),
                    FR = table.Column<int>(type: "INTEGER", nullable: false),
                    Diagnostico = table.Column<string>(type: "TEXT", nullable: false),
                    Hemogramas = table.Column<int>(type: "INTEGER", nullable: false),
                    ExOrina = table.Column<int>(name: "Ex_Orina", type: "INTEGER", nullable: false),
                    Glisemia = table.Column<int>(type: "INTEGER", nullable: false),
                    Coprologico = table.Column<int>(type: "INTEGER", nullable: false),
                    Imagenes = table.Column<int>(type: "INTEGER", nullable: false),
                    Especifique = table.Column<string>(type: "TEXT", nullable: false),
                    TyM = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencia", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "EmergenciaA",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmergenciaID = table.Column<string>(type: "TEXT", nullable: false),
                    ARS = table.Column<int>(type: "INTEGER", nullable: false),
                    NSS = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Hora = table.Column<int>(type: "INTEGER", nullable: false),
                    MConsulta = table.Column<string>(name: "M_Consulta", type: "TEXT", nullable: false),
                    Antecedentes = table.Column<string>(type: "TEXT", nullable: false),
                    AtencionesPrevias = table.Column<bool>(type: "INTEGER", nullable: false),
                    Donde = table.Column<string>(type: "TEXT", nullable: false),
                    MedicoBase = table.Column<string>(type: "TEXT", nullable: false),
                    Peso = table.Column<int>(type: "INTEGER", nullable: false),
                    TA = table.Column<int>(type: "INTEGER", nullable: false),
                    FC = table.Column<int>(type: "INTEGER", nullable: false),
                    FR = table.Column<int>(type: "INTEGER", nullable: false),
                    Temperatura = table.Column<int>(type: "INTEGER", nullable: false),
                    Cabeza = table.Column<string>(type: "TEXT", nullable: false),
                    Cuello = table.Column<string>(type: "TEXT", nullable: false),
                    Torax = table.Column<string>(type: "TEXT", nullable: false),
                    Pulmones = table.Column<string>(type: "TEXT", nullable: false),
                    Corazon = table.Column<string>(type: "TEXT", nullable: false),
                    Abdomen = table.Column<string>(type: "TEXT", nullable: false),
                    EInferiores = table.Column<string>(name: "E_Inferiores", type: "TEXT", nullable: false),
                    ESuperiores = table.Column<string>(name: "E_Superiores", type: "TEXT", nullable: false),
                    Diagnostico = table.Column<string>(type: "TEXT", nullable: false),
                    Hemogramas = table.Column<int>(type: "INTEGER", nullable: false),
                    ExOrina = table.Column<int>(name: "Ex_Orina", type: "INTEGER", nullable: false),
                    Glisemia = table.Column<int>(type: "INTEGER", nullable: false),
                    Coprologico = table.Column<int>(type: "INTEGER", nullable: false),
                    Imagenes = table.Column<int>(type: "INTEGER", nullable: false),
                    Especifique = table.Column<string>(type: "TEXT", nullable: false),
                    TyM = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergenciaA", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false),
                    PacienteID = table.Column<string>(type: "TEXT", nullable: false),
                    PrimerNombre = table.Column<string>(type: "TEXT", nullable: false),
                    SegundoNombre = table.Column<string>(type: "TEXT", nullable: false),
                    PrimerApellido = table.Column<string>(type: "TEXT", nullable: false),
                    sexo = table.Column<int>(type: "INTEGER", nullable: false),
                    FechadeNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Provincia = table.Column<int>(type: "INTEGER", nullable: false),
                    Municipio = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.OrdenID);
                    table.ForeignKey(
                        name: "FK_Paciente_EmergenciaA_OrdenID",
                        column: x => x.OrdenID,
                        principalTable: "EmergenciaA",
                        principalColumn: "OrdenID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_Emergencia_OrdenID",
                        column: x => x.OrdenID,
                        principalTable: "Emergencia",
                        principalColumn: "OrdenID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "EmergenciaA");

            migrationBuilder.DropTable(
                name: "Emergencia");
        }
    }
}
