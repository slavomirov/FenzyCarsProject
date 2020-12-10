using Microsoft.EntityFrameworkCore.Migrations;

namespace FenzyCars.Data.Migrations
{
    public partial class SomeUpdatesForMessagesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                table: "SendedMessages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecieverId",
                table: "SendedMessages",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RecieverId",
                table: "RecievedMessages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "RecievedMessages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SendedMessages_RecieverId",
                table: "SendedMessages",
                column: "RecieverId");

            migrationBuilder.CreateIndex(
                name: "IX_RecievedMessages_SenderId",
                table: "RecievedMessages",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecievedMessages_AspNetUsers_SenderId",
                table: "RecievedMessages",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendedMessages_AspNetUsers_RecieverId",
                table: "SendedMessages",
                column: "RecieverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecievedMessages_AspNetUsers_SenderId",
                table: "RecievedMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_SendedMessages_AspNetUsers_RecieverId",
                table: "SendedMessages");

            migrationBuilder.DropIndex(
                name: "IX_SendedMessages_RecieverId",
                table: "SendedMessages");

            migrationBuilder.DropIndex(
                name: "IX_RecievedMessages_SenderId",
                table: "RecievedMessages");

            migrationBuilder.DropColumn(
                name: "RecieverId",
                table: "SendedMessages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "RecievedMessages");

            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                table: "SendedMessages",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RecieverId",
                table: "RecievedMessages",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
