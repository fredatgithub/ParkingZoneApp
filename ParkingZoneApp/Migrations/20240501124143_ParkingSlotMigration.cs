﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingZoneApp.Migrations
{
    /// <inheritdoc />
    public partial class ParkingSlotMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    IsAvailableForBooking = table.Column<bool>(type: "bit", nullable: false),
                    ParkingZoneId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkingSlots_ParkingZones_ParkingZoneId",
                        column: x => x.ParkingZoneId,
                        principalTable: "ParkingZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkingSlots_ParkingZoneId",
                table: "ParkingSlots",
                column: "ParkingZoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingSlots");
        }
    }
}
