using Microsoft.EntityFrameworkCore.Migrations;

namespace RCB.TypeScript.Migrations
{
    public partial class Justchecking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_User_ManagerUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_User_ManagerUserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_User_ManagerUserId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Projects_ProjectId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_User_WorkerUserId",
                table: "WorkItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_ProjectId",
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
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProjectId",
                table: "User",
                newName: "IX_User_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_User_ManagerUserId",
                table: "Customers",
                column: "ManagerUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_User_ManagerUserId",
                table: "Projects",
                column: "ManagerUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_User_ManagerUserId",
                table: "Topics",
                column: "ManagerUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Projects_ProjectId",
                table: "User",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_User_WorkerUserId",
                table: "WorkItems",
                column: "WorkerUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
