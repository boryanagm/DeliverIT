using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class SeedEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "StreetName" },
                values: new object[,]
                {
                    { new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"), new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"), new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(2192), null, null, null, "Gran Via De Les Corts Catalanes 105" },
                    { new Guid("da703902-00bc-47da-b950-4fa730494d4e"), new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"), new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(2201), null, null, null, "Passatge De Bocabella 11" }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 802, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 802, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 802, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 802, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 801, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 801, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 801, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 801, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 802, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 802, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 802, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 802, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "CreatedOn", "DeletedOn", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedOn" },
                values: new object[] { new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"), new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"), new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(5788), null, "fer.trujillo@gmail.com", "Fermin", null, "Trujillo", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "CreatedOn", "DeletedOn", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedOn" },
                values: new object[] { new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"), new Guid("da703902-00bc-47da-b950-4fa730494d4e"), new DateTime(2021, 4, 11, 11, 32, 6, 803, DateTimeKind.Utc).AddTicks(6880), null, "a.rivas@gmail.com", "Amador", null, "Rivas", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("da703902-00bc-47da-b950-4fa730494d4e"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 14, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 14, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 14, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 14, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 21, 35, 16, DateTimeKind.Utc).AddTicks(5940));
        }
    }
}
