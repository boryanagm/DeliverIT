using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 886, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 886, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 886, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 885, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 887, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 887, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 887, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 887, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 889, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 889, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e9a6b4e2-073b-4ebc-a248-a8d71d426174"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 889, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 889, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("198457ae-236c-4592-90af-3ca2302a8737"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 890, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 890, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 27, 0, 26, 20, 891, DateTimeKind.Utc).AddTicks(202), new DateTime(2021, 4, 20, 0, 26, 20, 890, DateTimeKind.Utc).AddTicks(9633), new DateTime(2021, 4, 20, 0, 26, 20, 890, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 25, 0, 26, 20, 891, DateTimeKind.Utc).AddTicks(2003), new DateTime(2021, 4, 20, 0, 26, 20, 891, DateTimeKind.Utc).AddTicks(1996), new DateTime(2021, 4, 20, 0, 26, 20, 891, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 20, 0, 26, 20, 888, DateTimeKind.Utc).AddTicks(7658));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 441, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 441, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 441, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 441, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e9a6b4e2-073b-4ebc-a248-a8d71d426174"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("198457ae-236c-4592-90af-3ca2302a8737"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 445, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 445, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 26, 16, 15, 38, 445, DateTimeKind.Utc).AddTicks(7354), new DateTime(2021, 4, 19, 16, 15, 38, 445, DateTimeKind.Utc).AddTicks(7010), new DateTime(2021, 4, 19, 16, 15, 38, 445, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                columns: new[] { "ArrivalDate", "CreatedOn", "DepartureDate" },
                values: new object[] { new DateTime(2021, 4, 24, 16, 15, 38, 445, DateTimeKind.Utc).AddTicks(8403), new DateTime(2021, 4, 19, 16, 15, 38, 445, DateTimeKind.Utc).AddTicks(8394), new DateTime(2021, 4, 19, 16, 15, 38, 445, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 443, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 16, 15, 38, 444, DateTimeKind.Utc).AddTicks(1724));
        }
    }
}
