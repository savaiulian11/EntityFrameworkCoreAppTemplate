using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNETCoreLearning.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeys1 : Migration
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

            migrationBuilder.RenameColumn(
                name: "NavCustomerId",
                table: "Loans",
                newName: "IdCustomer");

            migrationBuilder.RenameColumn(
                name: "NavBookId",
                table: "Loans",
                newName: "IdBook");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_NavCustomerId",
                table: "Loans",
                newName: "IX_Loans_IdCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_NavBookId",
                table: "Loans",
                newName: "IX_Loans_IdBook");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_IdBook",
                table: "Loans",
                column: "IdBook",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_IdCustomer",
                table: "Loans",
                column: "IdCustomer",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_IdBook",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_IdCustomer",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "IdCustomer",
                table: "Loans",
                newName: "NavCustomerId");

            migrationBuilder.RenameColumn(
                name: "IdBook",
                table: "Loans",
                newName: "NavBookId");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_IdCustomer",
                table: "Loans",
                newName: "IX_Loans_NavCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_IdBook",
                table: "Loans",
                newName: "IX_Loans_NavBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_NavBookId",
                table: "Loans",
                column: "NavBookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_NavCustomerId",
                table: "Loans",
                column: "NavCustomerId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
