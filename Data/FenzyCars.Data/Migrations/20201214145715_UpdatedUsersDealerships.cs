using Microsoft.EntityFrameworkCore.Migrations;

namespace FenzyCars.Data.Migrations
{
    public partial class UpdatedUsersDealerships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Dealerships_AspNetUsers_OwnerId",
            //    table: "Dealerships");

            //migrationBuilder.DropIndex(
            //    name: "IX_Dealerships_OwnerId",
            //    table: "Dealerships");

            //migrationBuilder.DropColumn(
            //    name: "OwnerId",
            //    table: "Dealerships");

            //migrationBuilder.CreateTable(
            //    name: "UserDealerships",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(nullable: true),
            //        DealershipId = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserDealerships", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_UserDealerships_Dealerships_DealershipId",
            //            column: x => x.DealershipId,
            //            principalTable: "Dealerships",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_UserDealerships_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserDealerships_DealershipId",
            //    table: "UserDealerships",
            //    column: "DealershipId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserDealerships_UserId",
            //    table: "UserDealerships",
            //    column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "UserDealerships");

            //migrationBuilder.AddColumn<string>(
            //    name: "OwnerId",
            //    table: "Dealerships",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dealerships_OwnerId",
            //    table: "Dealerships",
            //    column: "OwnerId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Dealerships_AspNetUsers_OwnerId",
            //    table: "Dealerships",
            //    column: "OwnerId",
            //    principalTable: "AspNetUsers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
