using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FenzyCars.Data.Migrations
{
    public partial class DeletedMessagesAndAddedTwoTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Messages_MessageId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "UserMessages");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Image_MessageId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Image");

            migrationBuilder.AddColumn<int>(
                name: "RecievedMessageId",
                table: "Image",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SendedMessageId",
                table: "Image",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RecievedMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecievedMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecievedMessages_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SendedMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendedMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SendedMessages_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRecievedMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(nullable: true),
                    MessageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRecievedMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRecievedMessages_RecievedMessages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "RecievedMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRecievedMessages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSendedMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecieverId = table.Column<string>(nullable: true),
                    MessageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSendedMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSendedMessages_SendedMessages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "SendedMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSendedMessages_AspNetUsers_RecieverId",
                        column: x => x.RecieverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_RecievedMessageId",
                table: "Image",
                column: "RecievedMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_SendedMessageId",
                table: "Image",
                column: "SendedMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_RecievedMessages_ApplicationUserId",
                table: "RecievedMessages",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SendedMessages_ApplicationUserId",
                table: "SendedMessages",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRecievedMessages_MessageId",
                table: "UserRecievedMessages",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRecievedMessages_SenderId",
                table: "UserRecievedMessages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSendedMessages_MessageId",
                table: "UserSendedMessages",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSendedMessages_RecieverId",
                table: "UserSendedMessages",
                column: "RecieverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_RecievedMessages_RecievedMessageId",
                table: "Image",
                column: "RecievedMessageId",
                principalTable: "RecievedMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_SendedMessages_SendedMessageId",
                table: "Image",
                column: "SendedMessageId",
                principalTable: "SendedMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_RecievedMessages_RecievedMessageId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_SendedMessages_SendedMessageId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "UserRecievedMessages");

            migrationBuilder.DropTable(
                name: "UserSendedMessages");

            migrationBuilder.DropTable(
                name: "RecievedMessages");

            migrationBuilder.DropTable(
                name: "SendedMessages");

            migrationBuilder.DropIndex(
                name: "IX_Image_RecievedMessageId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_SendedMessageId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "RecievedMessageId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "SendedMessageId",
                table: "Image");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    RecieverId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMessages_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserMessages_AspNetUsers_RecieverId",
                        column: x => x.RecieverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserMessages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_MessageId",
                table: "Image",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ApplicationUserId",
                table: "Messages",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_MessageId",
                table: "UserMessages",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_RecieverId",
                table: "UserMessages",
                column: "RecieverId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_SenderId",
                table: "UserMessages",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Messages_MessageId",
                table: "Image",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
