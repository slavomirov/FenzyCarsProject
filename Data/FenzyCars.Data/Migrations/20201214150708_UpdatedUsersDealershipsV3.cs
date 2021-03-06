﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FenzyCars.Data.Migrations
{
    public partial class UpdatedUsersDealershipsV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "DealershipCars",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CarId = table.Column<int>(nullable: false),
            //        DealershipId = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DealershipCars", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_DealershipCars_Cars_CarId",
            //            column: x => x.CarId,
            //            principalTable: "Cars",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DealershipCars_Dealerships_DealershipId",
            //            column: x => x.DealershipId,
            //            principalTable: "Dealerships",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_DealershipCars_CarId",
            //    table: "DealershipCars",
            //    column: "CarId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DealershipCars_DealershipId",
            //    table: "DealershipCars",
            //    column: "DealershipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.DropTable(
            //        name: "DealershipCars");
        }
    }
}
