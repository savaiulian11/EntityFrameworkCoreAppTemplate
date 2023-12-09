using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNETCoreLearning.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeys2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_IdBook",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_IdCustomer",
                table: "Loans");

            migrationBuilder.AlterColumn<int>(
                name: "IdCustomer",
                table: "Loans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdBook",
                table: "Loans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_IdBook",
                table: "Loans",
                column: "IdBook",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_IdCustomer",
                table: "Loans",
                column: "IdCustomer",
                principalTable: "Books",
                principalColumn: "Id");
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

            migrationBuilder.AlterColumn<int>(
                name: "IdCustomer",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdBook",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_IdBook",
                table: "Loans",
                column: "IdBook",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_IdCustomer",
                table: "Loans",
                column: "IdCustomer",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
