using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationManager.Migrations
{
    public partial class AddedRegisterInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientData_Reservations_ReservationId",
                table: "ClientData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientData",
                table: "ClientData");

            migrationBuilder.RenameTable(
                name: "ClientData",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_ClientData_ReservationId",
                table: "Clients",
                newName: "IX_Clients_ReservationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Reservations_ReservationId",
                table: "Clients",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Reservations_ReservationId",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "ClientData");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_ReservationId",
                table: "ClientData",
                newName: "IX_ClientData_ReservationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientData",
                table: "ClientData",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientData_Reservations_ReservationId",
                table: "ClientData",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId");
        }
    }
}
