using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class RemoveWarwhouseForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Warehouses_WarehouseId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_WarehouseId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Addresses_AddressId",
                table: "Warehouses",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Addresses_AddressId",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_WarehouseId",
                table: "Addresses",
                column: "WarehouseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Warehouses_WarehouseId",
                table: "Addresses",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
