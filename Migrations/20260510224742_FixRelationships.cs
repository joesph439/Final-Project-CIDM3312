using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project_CIDM3312.Migrations
{
    /// <inheritdoc />
    public partial class FixRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Statss_StatsID",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Characters_CharacterID",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_CharacterID",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Characters_StatsID",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharacterID",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "StatsID",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Statss_CharacterID",
                table: "Statss",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PlayerID",
                table: "Characters",
                column: "PlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Players_PlayerID",
                table: "Characters",
                column: "PlayerID",
                principalTable: "Players",
                principalColumn: "PlayerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Statss_Characters_CharacterID",
                table: "Statss",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Players_PlayerID",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Statss_Characters_CharacterID",
                table: "Statss");

            migrationBuilder.DropIndex(
                name: "IX_Statss_CharacterID",
                table: "Statss");

            migrationBuilder.DropIndex(
                name: "IX_Characters_PlayerID",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "CharacterID",
                table: "Players",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatsID",
                table: "Characters",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_CharacterID",
                table: "Players",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_StatsID",
                table: "Characters",
                column: "StatsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Statss_StatsID",
                table: "Characters",
                column: "StatsID",
                principalTable: "Statss",
                principalColumn: "StatsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Characters_CharacterID",
                table: "Players",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID");
        }
    }
}
