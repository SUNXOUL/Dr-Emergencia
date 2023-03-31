using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrEmergencias.Migrations
{
    /// <inheritdoc />
    public partial class AjusteEstado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "OrdenCompras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 6,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 7,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 8,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 9,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 10,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Suplidores",
                keyColumn: "SuplidorID",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Suplidores",
                keyColumn: "SuplidorID",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Suplidores",
                keyColumn: "SuplidorID",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 31, 13, 51, 46, 10, DateTimeKind.Local).AddTicks(7325));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "OrdenCompras");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 6,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 7,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 8,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 9,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteID",
                keyValue: 10,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Suplidores",
                keyColumn: "SuplidorID",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Suplidores",
                keyColumn: "SuplidorID",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Suplidores",
                keyColumn: "SuplidorID",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2023, 3, 24, 13, 8, 17, 325, DateTimeKind.Local).AddTicks(1763));
        }
    }
}
