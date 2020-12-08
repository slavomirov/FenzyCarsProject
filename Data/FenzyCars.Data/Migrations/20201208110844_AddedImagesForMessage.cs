using Microsoft.EntityFrameworkCore.Migrations;

namespace FenzyCars.Data.Migrations
{
    public partial class AddedImagesForMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Image_ImageId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ImageId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Image",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Image_MessageId",
                table: "Image",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Messages_MessageId",
                table: "Image",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Messages_MessageId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_MessageId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Image");

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ImageId",
                table: "Messages",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Image_ImageId",
                table: "Messages",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
