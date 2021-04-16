using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class MakeCreatedOnRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 288, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 288, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 288, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 288, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("198457ae-236c-4592-90af-3ca2302a8737"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(4922), new DateTime(2021, 4, 16, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(4569), new DateTime(2021, 4, 16, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 21, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(6376), new DateTime(2021, 4, 16, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(6359), new DateTime(2021, 4, 16, 17, 27, 59, 291, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 27, 59, 290, DateTimeKind.Utc).AddTicks(7335));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 577, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 577, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 577, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 577, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("198457ae-236c-4592-90af-3ca2302a8737"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(4335), new DateTime(2021, 4, 16, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(4000), new DateTime(2021, 4, 16, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 21, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(5454), new DateTime(2021, 4, 16, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(5428), new DateTime(2021, 4, 16, 17, 19, 2, 580, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 16, 17, 19, 2, 579, DateTimeKind.Utc).AddTicks(6697));
        }
    }
}
