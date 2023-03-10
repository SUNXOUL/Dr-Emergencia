using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrEmergencias.Migrations
{
    /// <inheritdoc />
    public partial class FixingerrorsinEntradas : Migration
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
                    SuplidorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Costo = table.Column<double>(type: "REAL", nullable: true),
                    Precio = table.Column<double>(type: "REAL", nullable: true),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: true),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    NumReorden = table.Column<int>(name: "Num_Reorden", type: "INTEGER", nullable: false),
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
                    NSS = table.Column<string>(type: "TEXT", nullable: false),
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
                    cantidadanterior = table.Column<int>(name: "cantidad_anterior", type: "INTEGER", nullable: true),
                    Razon = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "OrdenCompras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SuplidorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenCompras", x => x.CompraId);
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
                    cantidadanterior = table.Column<int>(name: "cantidad_anterior", type: "INTEGER", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "ComprasDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false),
                    ArticuloId = table.Column<int>(type: "INTEGER", nullable: false),
                    cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    costo = table.Column<double>(type: "REAL", nullable: false),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_ComprasDetalle_OrdenCompras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "OrdenCompras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteID", "Alergia", "Cedula", "CedulaTutor", "Direccion", "Edad", "FechadeNacimiento", "Municipio", "Ocupacion", "PrimerApellido", "PrimerNombre", "Provincia", "SegundoApellido", "SegundoNombre", "Sexo", "Telefono", "Tutor", "Visible" },
                values: new object[,]
                {
                    { 1, null, "809-7877890-1", null, "Nagua,RD", 19, "3/8/2003", "Nagua", "DBA", "Reynoso", "Cesar", "MTS", null, "Jose", "Hombre", "829-567-9072", null, true },
                    { 2, null, "222-3377890-3", null, "Pinia 3", 17, "3/8/2005", "SFM", "Agricultor", "Sanchez", "Em", "Duarte", null, "Ramon", "Hombre", "849-343-0000", null, true },
                    { 3, null, "332-4447822-2", null, "SALCEDO, LAS cuevas", 23, "3/8/2000", "Salcedo", "Estilista", "Almonte", "Camila", "Duarte", "Castellanos", "", "Mujer", "787-567-9072", null, true },
                    { 4, null, "402-7877890-1", null, "Cabrera, La entrada", 33, "3/8/1990", "Cabrera", "Civil Engenieer", "Rodriguez", "Kinsgton", "MTS", null, "Elsmon", "Hombre", "829-337-9712", null, true },
                    { 5, null, "888-7899890-1", null, "Spain, MALLORCA", 26, "3/8/1997", "N", "Analista de sistemas", "Lopez", "Jeison", "N", "Javier", "Lo", "Hombre", "829-567-7777", null, true },
                    { 6, null, "867-1877111-1", null, "USA, CANADA", 20, "3/8/2002", "N", "Enterprise ADMIN", "JULIENS", "Yoland", "N", null, "Ves", "Mujer", "829-567-8890", null, true },
                    { 7, null, "222-1111111-1", null, "France, Paris", 18, "3/8/2004", "N", "Senior Dev", "Estrella", "Holland", "N", null, "Gab", "Hombre", "878-567-9072", null, true },
                    { 8, null, "666-7877890-1", null, "Nagua,RD", 19, "3/8/2003", "Nagua", "Alquimista", "Martinez", "Nou", "MTS", null, "ester", "Mujer", "829-567-333", null, true },
                    { 9, null, "123-7877890-1", null, "Nagua,RD", 19, "3/8/2003", "Nagua", "Dto", "Ilstens", "C", "MTS", null, "James", "Hombre", "119-227-3372", null, true },
                    { 10, null, "804-4877890-4", null, "Nagua,RD", 19, "3/8/2003", "Nagua", "DBA", "Fernandez", "Amanda", "MTS", null, "", "Mujer", "829-567-4444", null, true }
                });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorID", "Contacto", "Nombre", "Visible" },
                values: new object[,]
                {
                    { 1, "829-787-5366", "GBC Enterprise", true },
                    { 2, "809-123-9933", "FarmaSalud", true },
                    { 3, "829-863-5107", "Minoxidil", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComprasDetalle_CompraId",
                table: "ComprasDetalle",
                column: "CompraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "ComprasDetalle");

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

            migrationBuilder.DropTable(
                name: "OrdenCompras");
        }
    }
}
