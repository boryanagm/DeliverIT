using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class DemoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Warehouses_WarehouseId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_WarehouseId",
                table: "Addresses");

            migrationBuilder.AlterColumn<Guid>(
                name: "AddressId",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses");

            migrationBuilder.AlterColumn<Guid>(
                name: "AddressId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_WarehouseId",
                table: "Addresses",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Warehouses_WarehouseId",
                table: "Addresses",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
