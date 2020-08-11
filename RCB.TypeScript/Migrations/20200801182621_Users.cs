using Microsoft.EntityFrameworkCore.Migrations;

namespace RCB.TypeScript.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TestUsers_ManagerUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_TestUsers_ManagerUserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_TestUsers_Projects_ProjectId",
                table: "TestUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_TestUsers_ManagerUserId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_TestUsers_WorkerUserId",
                table: "WorkItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestUsers",
                table: "TestUsers");

            migrationBuilder.RenameTable(
                name: "TestUsers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_TestUsers_ProjectId",
                table: "Users",
                newName: "IX_Users_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_ManagerUserId",
                table: "Customers",
                column: "ManagerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_ManagerUserId",
                table: "Projects",
                column: "ManagerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Users_ManagerUserId",
                table: "Topics",
                column: "ManagerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Projects_ProjectId",
                table: "Users",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Users_WorkerUserId",
                table: "WorkItems",
                column: "WorkerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_ManagerUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ManagerUserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Users_ManagerUserId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Projects_ProjectId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Users_WorkerUserId",
                table: "WorkItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "TestUsers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProjectId",
                table: "TestUsers",
                newName: "IX_TestUsers_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestUsers",
                table: "TestUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TestUsers_ManagerUserId",
                table: "Customers",
                column: "ManagerUserId",
                principalTable: "TestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_TestUsers_ManagerUserId",
                table: "Projects",
                column: "ManagerUserId",
                principalTable: "TestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestUsers_Projects_ProjectId",
                table: "TestUsers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_TestUsers_ManagerUserId",
                table: "Topics",
                column: "ManagerUserId",
                principalTable: "TestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_TestUsers_WorkerUserId",
                table: "WorkItems",
                column: "WorkerUserId",
                principalTable: "TestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
