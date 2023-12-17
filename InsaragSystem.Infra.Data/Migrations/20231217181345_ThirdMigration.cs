using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsaragSystem.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Sectors_SectorId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SectorId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "Teams");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectorId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SectorId",
                table: "Teams",
                column: "SectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Sectors_SectorId",
                table: "Teams",
                column: "SectorId",
                principalTable: "Sectors",
                principalColumn: "Id");
        }
    }
}
