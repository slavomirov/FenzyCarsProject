using Microsoft.EntityFrameworkCore.Migrations;

namespace FenzyCars.Data.Migrations
{
    public partial class UpdatedUsersDealershipsAndCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "DealershipCars");

            //migrationBuilder.AlterColumn<string>(
            //    name: "PhoneNumber",
            //    table: "Dealerships",
            //    maxLength: 10,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)");

            //migrationBuilder.AddColumn<string>(
            //    name: "OwnerId",
            //    table: "Dealerships",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "DealershipId",
            //    table: "Cars",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dealerships_OwnerId",
            //    table: "Dealerships",
            //    column: "OwnerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cars_DealershipId",
            //    table: "Cars",
            //    column: "DealershipId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Cars_Dealerships_DealershipId",
            //    table: "Cars",
            //    column: "DealershipId",
            //    principalTable: "Dealerships",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Dealerships_AspNetUsers_OwnerId",
            //    table: "Dealerships",
            //    column: "OwnerId",
            //    principalTable: "AspNetUsers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Cars_Dealerships_DealershipId",
            //    table: "Cars");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Dealerships_AspNetUsers_OwnerId",
            //    table: "Dealerships");

            //migrationBuilder.DropIndex(
            //    name: "IX_Dealerships_OwnerId",
            //    table: "Dealerships");

            //migrationBuilder.DropIndex(
            //    name: "IX_Cars_DealershipId",
            //    table: "Cars");

            //migrationBuilder.DropColumn(
            //    name: "OwnerId",
            //    table: "Dealerships");

            //migrationBuilder.DropColumn(
            //    name: "DealershipId",
            //    table: "Cars");

            //migrationBuilder.AlterColumn<string>(
            //    name: "PhoneNumber",
            //    table: "Dealerships",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 10);

            //migrationBuilder.CreateTable(
            //    name: "DealershipCars",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CarId = table.Column<int>(type: "int", nullable: false),
            //        DealershipId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
    }
}
