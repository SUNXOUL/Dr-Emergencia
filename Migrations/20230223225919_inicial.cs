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
                name: "Emergencia",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmergenciaID = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MConsulta = table.Column<string>(name: "M_Consulta", type: "TEXT", nullable: true),
                    Antecedentes = table.Column<string>(type: "TEXT", nullable: true),
                    AtencionesPrevias = table.Column<bool>(type: "INTEGER", nullable: true),
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
                    TyM = table.Column<string>(type: "TEXT", nullable: true)
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
                    EmergenciaID = table.Column<string>(type: "TEXT", nullable: true),
                    ARS = table.Column<string>(type: "TEXT", nullable: true),
                    NSS = table.Column<int>(type: "INTEGER", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MConsulta = table.Column<string>(name: "M_Consulta", type: "TEXT", nullable: true),
                    Antecedentes = table.Column<string>(type: "TEXT", nullable: true),
                    AtencionesPrevias = table.Column<bool>(type: "INTEGER", nullable: true),
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
                    Visible = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergenciaA", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
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
                    table.PrimaryKey("PK_Paciente", x => x.PacienteID);
                });

            migrationBuilder.CreateTable(
                name: "EmergenciaADetalle",
                columns: table => new
                {
                    ADetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PacienteID = table.Column<int>(type: "INTEGER", nullable: false),
                    EmergenciaAId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergenciaADetalle", x => x.ADetalleId);
                    table.ForeignKey(
                        name: "FK_EmergenciaADetalle_Paciente_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Paciente",
                        principalColumn: "PacienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergenciaDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PacienteID = table.Column<int>(type: "INTEGER", nullable: false),
                    EmergenciaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergenciaDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_EmergenciaDetalle_Paciente_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Paciente",
                        principalColumn: "PacienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmergenciaADetalle_PacienteID",
                table: "EmergenciaADetalle",
                column: "PacienteID");

            migrationBuilder.CreateIndex(
                name: "IX_EmergenciaDetalle_PacienteID",
                table: "EmergenciaDetalle",
                column: "PacienteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emergencia");

            migrationBuilder.DropTable(
                name: "EmergenciaA");

            migrationBuilder.DropTable(
                name: "EmergenciaADetalle");

            migrationBuilder.DropTable(
                name: "EmergenciaDetalle");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
