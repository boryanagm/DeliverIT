﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class DropParcels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parcels_Warehouses_WarehouseId",
                table: "Parcels");

            migrationBuilder.DropIndex(
                name: "IX_Parcels_WarehouseId",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Parcels");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 256, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 256, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 256, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 256, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("198457ae-236c-4592-90af-3ca2302a8737"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 260, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 260, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 23, 22, 4, 1, 260, DateTimeKind.Utc).AddTicks(5367), new DateTime(2021, 4, 16, 22, 4, 1, 260, DateTimeKind.Utc).AddTicks(4816), new DateTime(2021, 4, 16, 22, 4, 1, 260, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 21, 22, 4, 1, 260, DateTimeKind.Utc).AddTicks(7180), new DateTime(2021, 4, 16, 22, 4, 1, 260, DateTimeKind.Utc).AddTicks(7169), new DateTime(2021, 4, 16, 22, 4, 1, 260, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 258, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 4, 1, 259, DateTimeKind.Utc).AddTicks(1969));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "WarehouseId",
                table: "Parcels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 954, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 954, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 954, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 954, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 957, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 957, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 957, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 957, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("198457ae-236c-4592-90af-3ca2302a8737"),
                columns: new[] { "CreatedOn", "WarehouseId" },
                values: new object[] { new DateTime(2021, 4, 16, 22, 0, 55, 957, DateTimeKind.Utc).AddTicks(9354), new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba") });

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                columns: new[] { "CreatedOn", "WarehouseId" },
                values: new object[] { new DateTime(2021, 4, 16, 22, 0, 55, 958, DateTimeKind.Utc).AddTicks(3081), new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693") });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 23, 22, 0, 55, 958, DateTimeKind.Utc).AddTicks(4737), new DateTime(2021, 4, 16, 22, 0, 55, 958, DateTimeKind.Utc).AddTicks(4171), new DateTime(2021, 4, 16, 22, 0, 55, 958, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 21, 22, 0, 55, 958, DateTimeKind.Utc).AddTicks(6731), new DateTime(2021, 4, 16, 22, 0, 55, 958, DateTimeKind.Utc).AddTicks(6706), new DateTime(2021, 4, 16, 22, 0, 55, 958, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 957, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 957, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_WarehouseId",
                table: "Parcels",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parcels_Warehouses_WarehouseId",
                table: "Parcels",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
