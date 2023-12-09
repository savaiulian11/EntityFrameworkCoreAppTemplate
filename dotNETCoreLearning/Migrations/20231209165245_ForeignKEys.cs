using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNETCoreLearning.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKEys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_NavBookId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_NavCustomerId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "IdBook",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "IdCustomer",
                table: "Loans");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_NavBookId",
                table: "Loans",
                column: "NavBookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_NavCustomerId",
                table: "Loans",
                column: "NavCustomerId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_NavBookId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_NavCustomerId",
                table: "Loans");

            migrationBuilder.AddColumn<int>(
                name: "IdBook",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCustomer",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_NavBookId",
                table: "Loans",
                column: "NavBookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_NavCustomerId",
                table: "Loans",
                column: "NavCustomerId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
