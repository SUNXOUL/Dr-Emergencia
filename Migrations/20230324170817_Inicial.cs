using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrEmergencias.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    ArticuloID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuplidorId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Costo = table.Column<double>(type: "float", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: true),
                    Existencia = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_Reorden = table.Column<int>(type: "int", nullable: false),
                    Visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.ArticuloID);
                });

            migrationBuilder.CreateTable(
                name: "EmergenciaAs",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmergenciaID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    ARS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NSS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    M_Consulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Antecedentes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtencionesPrevias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Donde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicoBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<int>(type: "int", nullable: true),
                    TA = table.Column<int>(type: "int", nullable: true),
                    FC = table.Column<int>(type: "int", nullable: true),
                    FR = table.Column<int>(type: "int", nullable: true),
                    Temperatura = table.Column<int>(type: "int", nullable: true),
                    Cabeza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuello = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Torax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pulmones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Corazon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abdomen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E_Inferiores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E_Superiores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hemogramas = table.Column<int>(type: "int", nullable: true),
                    Ex_Orina = table.Column<int>(type: "int", nullable: true),
                    Glisemia = table.Column<int>(type: "int", nullable: true),
                    Coprologico = table.Column<int>(type: "int", nullable: true),
                    Imagenes = table.Column<int>(type: "int", nullable: true),
                    Especifique = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergenciaAs", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Emergencias",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmergenciaID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    M_Consulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Antecedentes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtencionesPrevias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Donde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicoBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<int>(type: "int", nullable: true),
                    TA = table.Column<int>(type: "int", nullable: true),
                    FC = table.Column<int>(type: "int", nullable: true),
                    FR = table.Column<int>(type: "int", nullable: true),
                    Temperatura = table.Column<int>(type: "int", nullable: true),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hemogramas = table.Column<int>(type: "int", nullable: true),
                    Ex_Orina = table.Column<int>(type: "int", nullable: true),
                    Glisemia = table.Column<int>(type: "int", nullable: true),
                    Coprologico = table.Column<int>(type: "int", nullable: true),
                    Imagenes = table.Column<int>(type: "int", nullable: true),
                    Especifique = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencias", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticuloID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    cantidad_anterior = table.Column<int>(type: "int", nullable: true),
                    cantidad_Resultante = table.Column<int>(type: "int", nullable: true),
                    Razon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "OrdenCompras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuplidorId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenCompras", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CedulaTutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alergia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechadeNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Visible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteID);
                });

            migrationBuilder.CreateTable(
                name: "Salidas",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticuloID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    cantidad_anterior = table.Column<int>(type: "int", nullable: true),
                    cantidad_Resultante = table.Column<int>(type: "int", nullable: true),
                    Razon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salidas", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Suplidores",
                columns: table => new
                {
                    SuplidorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplidores", x => x.SuplidorID);
                });

            migrationBuilder.CreateTable(
                name: "ComprasDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: true),
                    costo = table.Column<double>(type: "float", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false)
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
                columns: new[] { "PacienteID", "Alergia", "Cedula", "CedulaTutor", "Direccion", "Edad", "FechaRegistro", "FechadeNacimiento", "Municipio", "Ocupacion", "PrimerApellido", "PrimerNombre", "Provincia", "SegundoApellido", "SegundoNombre", "Sexo", "Telefono", "Tutor", "Visible" },
                values: new object[,]
                {
                    { 1, null, "809-7877890-1", null, "Nagua,RD", 19, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1497), "3/8/2003", "Nagua", "DBA", "Reynoso", "Cesar", "MTS", null, "Jose", "Hombre", "829-567-9072", null, true },
                    { 2, null, "222-3377890-3", null, "Pinia 3", 17, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1524), "3/8/2005", "SFM", "Agricultor", "Sanchez", "Em", "Duarte", null, "Ramon", "Hombre", "849-343-0000", null, true },
                    { 3, null, "332-4447822-2", null, "SALCEDO, LAS cuevas", 23, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1527), "3/8/2000", "Salcedo", "Estilista", "Almonte", "Camila", "Duarte", "Castellanos", "", "Mujer", "787-567-9072", null, true },
                    { 4, null, "402-7877890-1", null, "Cabrera, La entrada", 33, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1529), "3/8/1990", "Cabrera", "Civil Engenieer", "Rodriguez", "Kinsgton", "MTS", null, "Elsmon", "Hombre", "829-337-9712", null, true },
                    { 5, null, "888-7899890-1", null, "Spain, MALLORCA", 26, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1532), "3/8/1997", "N", "Analista de sistemas", "Lopez", "Jeison", "N", "Javier", "Lo", "Hombre", "829-567-7777", null, true },
                    { 6, null, "867-1877111-1", null, "USA, CANADA", 20, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1534), "3/8/2002", "N", "Enterprise ADMIN", "JULIENS", "Yoland", "N", null, "Ves", "Mujer", "829-567-8890", null, true },
                    { 7, null, "222-1111111-1", null, "France, Paris", 18, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1536), "3/8/2004", "N", "Senior Dev", "Estrella", "Holland", "N", null, "Gab", "Hombre", "878-567-9072", null, true },
                    { 8, null, "666-7877890-1", null, "Nagua,RD", 19, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1538), "3/8/2003", "Nagua", "Alquimista", "Martinez", "Nou", "MTS", null, "ester", "Mujer", "829-567-333", null, true },
                    { 9, null, "123-7877890-1", null, "Nagua,RD", 19, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1540), "3/8/2003", "Nagua", "Dto", "Ilstens", "C", "MTS", null, "James", "Hombre", "119-227-3372", null, true },
                    { 10, null, "804-4877890-4", null, "Nagua,RD", 19, new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1542), "3/8/2003", "Nagua", "DBA", "Fernandez", "Amanda", "MTS", null, "", "Mujer", "829-567-4444", null, true }
                });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorID", "Contacto", "FechaRegistro", "Nombre", "Visible" },
                values: new object[,]
                {
                    { 1, "829-787-5366", new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1759), "GBC Enterprise", true },
                    { 2, "809-123-9933", new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1762), "FarmaSalud", true },
                    { 3, "829-863-5107", new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1763), "Minoxidil", true }
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
