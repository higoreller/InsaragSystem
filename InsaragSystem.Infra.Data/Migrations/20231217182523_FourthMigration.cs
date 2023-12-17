using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsaragSystem.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisasterBaseDisasterId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectorId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_DisasterBaseDisasterId",
                table: "Teams",
                column: "DisasterBaseDisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SectorId",
                table: "Teams",
                column: "SectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Disasters_DisasterBaseDisasterId",
                table: "Teams",
                column: "DisasterBaseDisasterId",
                principalTable: "Disasters",
                principalColumn: "DisasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Sectors_SectorId",
                table: "Teams",
                column: "SectorId",
                principalTable: "Sectors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Disasters_DisasterBaseDisasterId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Sectors_SectorId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_DisasterBaseDisasterId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SectorId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "DisasterBaseDisasterId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "Teams");
        }
    }
}
