using Microsoft.EntityFrameworkCore.Migrations;

namespace FenzyCars.Data.Migrations
{
    public partial class UpdatedUsersDealershipsV7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "UserDealerships",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   DealershipId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                   UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_UserDealerships", x => x.Id);
                   table.ForeignKey(
                       name: "FK_UserDealerships_Dealerships_DealershipId",
                       column: x => x.DealershipId,
                       principalTable: "Dealerships",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                   table.ForeignKey(
                       name: "FK_UserDealerships_AspNetUsers_UserId",
                       column: x => x.UserId,
                       principalTable: "AspNetUsers",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
               });

            migrationBuilder.CreateIndex(
                name: "IX_UserDealerships_DealershipId",
                table: "UserDealerships",
                column: "DealershipId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDealerships_UserId",
                table: "UserDealerships",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
