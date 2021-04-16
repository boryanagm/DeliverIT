using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parcels_Employees_EmployeeId",
                table: "Parcels");

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
                columns: new[] { "CreatedOn", "CustomerId" },
                values: new object[] { new DateTime(2021, 4, 16, 22, 0, 55, 957, DateTimeKind.Utc).AddTicks(9354), new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331") });

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 22, 0, 55, 958, DateTimeKind.Utc).AddTicks(3081));

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
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2021, 4, 16, 22, 0, 55, 956, DateTimeKind.Utc).AddTicks(7357), "on the way" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Parcels_Employees_EmployeeId",
                table: "Parcels",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parcels_Employees_EmployeeId",
                table: "Parcels");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 903, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 903, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 903, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 903, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("198457ae-236c-4592-90af-3ca2302a8737"),
                columns: new[] { "CreatedOn", "CustomerId" },
                values: new object[] { new DateTime(2021, 4, 15, 21, 58, 31, 907, DateTimeKind.Utc).AddTicks(876), new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1") });

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 907, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 22, 21, 58, 31, 907, DateTimeKind.Utc).AddTicks(8790), new DateTime(2021, 4, 15, 21, 58, 31, 907, DateTimeKind.Utc).AddTicks(8188), new DateTime(2021, 4, 15, 21, 58, 31, 907, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 58, 31, 908, DateTimeKind.Utc).AddTicks(890), new DateTime(2021, 4, 15, 21, 58, 31, 908, DateTimeKind.Utc).AddTicks(857), new DateTime(2021, 4, 15, 21, 58, 31, 908, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(8466), "on The Way" });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 905, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 21, 58, 31, 906, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.AddForeignKey(
                name: "FK_Parcels_Employees_EmployeeId",
                table: "Parcels",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
