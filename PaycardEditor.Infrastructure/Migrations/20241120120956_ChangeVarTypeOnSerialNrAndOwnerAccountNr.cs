using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaycardEditor.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeVarTypeOnSerialNrAndOwnerAccountNr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SerialNr",
                schema: "paycardEditor",
                table: "Paycards",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerAccountNr",
                schema: "paycardEditor",
                table: "Paycards",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SerialNr",
                schema: "paycardEditor",
                table: "Paycards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerAccountNr",
                schema: "paycardEditor",
                table: "Paycards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);
        }
    }
}
