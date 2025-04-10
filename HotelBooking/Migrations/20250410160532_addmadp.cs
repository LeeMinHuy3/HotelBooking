using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    /// <inheritdoc />
    public partial class addmadp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaDP",
                table: "DatDichVus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DatDichVus_MaDP",
                table: "DatDichVus",
                column: "MaDP");

            migrationBuilder.AddForeignKey(
                name: "FK_DatDichVus_DatPhongs_MaDP",
                table: "DatDichVus",
                column: "MaDP",
                principalTable: "DatPhongs",
                principalColumn: "MaDP",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatDichVus_DatPhongs_MaDP",
                table: "DatDichVus");

            migrationBuilder.DropIndex(
                name: "IX_DatDichVus_MaDP",
                table: "DatDichVus");

            migrationBuilder.DropColumn(
                name: "MaDP",
                table: "DatDichVus");
        }
    }
}
