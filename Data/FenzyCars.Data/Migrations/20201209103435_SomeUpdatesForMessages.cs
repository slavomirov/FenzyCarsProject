using Microsoft.EntityFrameworkCore.Migrations;

namespace FenzyCars.Data.Migrations
{
    public partial class SomeUpdatesForMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecievedMessages_AspNetUsers_ApplicationUserId",
                table: "RecievedMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_SendedMessages_AspNetUsers_ApplicationUserId",
                table: "SendedMessages");

            migrationBuilder.DropIndex(
                name: "IX_SendedMessages_ApplicationUserId",
                table: "SendedMessages");

            migrationBuilder.DropIndex(
                name: "IX_RecievedMessages_ApplicationUserId",
                table: "RecievedMessages");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "SendedMessages");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "RecievedMessages");

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "SendedMessages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecieverId",
                table: "RecievedMessages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SendedMessages_SenderId",
                table: "SendedMessages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_RecievedMessages_RecieverId",
                table: "RecievedMessages",
                column: "RecieverId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecievedMessages_AspNetUsers_RecieverId",
                table: "RecievedMessages",
                column: "RecieverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendedMessages_AspNetUsers_SenderId",
                table: "SendedMessages",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecievedMessages_AspNetUsers_RecieverId",
                table: "RecievedMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_SendedMessages_AspNetUsers_SenderId",
                table: "SendedMessages");

            migrationBuilder.DropIndex(
                name: "IX_SendedMessages_SenderId",
                table: "SendedMessages");

            migrationBuilder.DropIndex(
                name: "IX_RecievedMessages_RecieverId",
                table: "RecievedMessages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "SendedMessages");

            migrationBuilder.DropColumn(
                name: "RecieverId",
                table: "RecievedMessages");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "SendedMessages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "RecievedMessages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SendedMessages_ApplicationUserId",
                table: "SendedMessages",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RecievedMessages_ApplicationUserId",
                table: "RecievedMessages",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecievedMessages_AspNetUsers_ApplicationUserId",
                table: "RecievedMessages",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendedMessages_AspNetUsers_ApplicationUserId",
                table: "SendedMessages",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
