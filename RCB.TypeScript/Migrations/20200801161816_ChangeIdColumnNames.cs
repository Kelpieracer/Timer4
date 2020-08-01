using Microsoft.EntityFrameworkCore.Migrations;

namespace RCB.TypeScript.Migrations
{
    public partial class ChangeIdColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Customers_CustomerID",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Customers_CustomerID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Customers_CustomerID",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Projects_ProjectID",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Projects_ProjectID",
                table: "WorkItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Rates_RateID",
                table: "WorkItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Topics_TopicsTopicID",
                table: "WorkItems");

            migrationBuilder.RenameColumn(
                name: "TopicsTopicID",
                table: "WorkItems",
                newName: "TopicsTopicId");

            migrationBuilder.RenameColumn(
                name: "RateID",
                table: "WorkItems",
                newName: "RateId");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "WorkItems",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "WorkItemID",
                table: "WorkItems",
                newName: "WorkItemId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_TopicsTopicID",
                table: "WorkItems",
                newName: "IX_WorkItems_TopicsTopicId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_RateID",
                table: "WorkItems",
                newName: "IX_WorkItems_RateId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_ProjectID",
                table: "WorkItems",
                newName: "IX_WorkItems_ProjectId");

            migrationBuilder.RenameColumn(
                name: "TopicID",
                table: "Topics",
                newName: "TopicId");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "Rates",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Rates",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "RateID",
                table: "Rates",
                newName: "RateId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_ProjectID",
                table: "Rates",
                newName: "IX_Rates_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_CustomerID",
                table: "Rates",
                newName: "IX_Rates_CustomerId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Projects",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "Projects",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CustomerID",
                table: "Projects",
                newName: "IX_Projects_CustomerId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Bills",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_CustomerID",
                table: "Bills",
                newName: "IX_Bills_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Customers_CustomerId",
                table: "Bills",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Customers_CustomerId",
                table: "Rates",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Projects_ProjectId",
                table: "Rates",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Projects_ProjectId",
                table: "WorkItems",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Rates_RateId",
                table: "WorkItems",
                column: "RateId",
                principalTable: "Rates",
                principalColumn: "RateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Topics_TopicsTopicId",
                table: "WorkItems",
                column: "TopicsTopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Customers_CustomerId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Customers_CustomerId",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Projects_ProjectId",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Projects_ProjectId",
                table: "WorkItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Rates_RateId",
                table: "WorkItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Topics_TopicsTopicId",
                table: "WorkItems");

            migrationBuilder.RenameColumn(
                name: "TopicsTopicId",
                table: "WorkItems",
                newName: "TopicsTopicID");

            migrationBuilder.RenameColumn(
                name: "RateId",
                table: "WorkItems",
                newName: "RateID");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "WorkItems",
                newName: "ProjectID");

            migrationBuilder.RenameColumn(
                name: "WorkItemId",
                table: "WorkItems",
                newName: "WorkItemID");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_TopicsTopicId",
                table: "WorkItems",
                newName: "IX_WorkItems_TopicsTopicID");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_RateId",
                table: "WorkItems",
                newName: "IX_WorkItems_RateID");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_ProjectId",
                table: "WorkItems",
                newName: "IX_WorkItems_ProjectID");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Topics",
                newName: "TopicID");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Rates",
                newName: "ProjectID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Rates",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "RateId",
                table: "Rates",
                newName: "RateID");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_ProjectId",
                table: "Rates",
                newName: "IX_Rates_ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_CustomerId",
                table: "Rates",
                newName: "IX_Rates_CustomerID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Projects",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Projects",
                newName: "ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                newName: "IX_Projects_CustomerID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Bills",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_CustomerId",
                table: "Bills",
                newName: "IX_Bills_CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Customers_CustomerID",
                table: "Bills",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Customers_CustomerID",
                table: "Projects",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Customers_CustomerID",
                table: "Rates",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Projects_ProjectID",
                table: "Rates",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Projects_ProjectID",
                table: "WorkItems",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Rates_RateID",
                table: "WorkItems",
                column: "RateID",
                principalTable: "Rates",
                principalColumn: "RateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Topics_TopicsTopicID",
                table: "WorkItems",
                column: "TopicsTopicID",
                principalTable: "Topics",
                principalColumn: "TopicID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
