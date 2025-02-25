using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_mig_reservation_car_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CarID",
                table: "Reservation",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Cars_CarID",
                table: "Reservation",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Cars_CarID",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_CarID",
                table: "Reservation");
        }
    }
}
