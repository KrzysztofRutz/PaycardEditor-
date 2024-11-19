using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaycardEditor.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPaycardDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "paycardEditor");

            migrationBuilder.CreateTable(
                name: "Paycards",
                schema: "paycardEditor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerAccountNr = table.Column<int>(type: "int", nullable: false),
                    PIN = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    SerialNr = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2(0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paycards", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paycards_CardId",
                schema: "paycardEditor",
                table: "Paycards",
                column: "CardId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paycards",
                schema: "paycardEditor");
        }
    }
}
