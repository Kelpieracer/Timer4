using Microsoft.EntityFrameworkCore.Migrations;

namespace RCB.TypeScript.Migrations
{
    public partial class AddedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "WorkerUserId",
                table: "WorkItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerUserId",
                table: "Topics",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ManagerUserId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerUserId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_WorkerUserId",
                table: "WorkItems",
                column: "WorkerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ManagerUserId",
                table: "Topics",
                column: "ManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ManagerUserId",
                table: "Projects",
                column: "ManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ManagerUserId",
                table: "Customers",
                column: "ManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProjectId",
                table: "User",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_User_ManagerUserId",
                table: "Customers",
                column: "ManagerUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
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
                name: "FK_WorkItems_User_WorkerUserId",
                table: "WorkItems",
                column: "WorkerUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_User_ManagerUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_User_ManagerUserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_User_ManagerUserId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_User_WorkerUserId",
                table: "WorkItems");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_WorkItems_WorkerUserId",
                table: "WorkItems");

            migrationBuilder.DropIndex(
                name: "IX_Topics_ManagerUserId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ManagerUserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ManagerUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "WorkerUserId",
                table: "WorkItems");

            migrationBuilder.DropColumn(
                name: "ManagerUserId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "ManagerUserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ManagerUserId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Projects",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
