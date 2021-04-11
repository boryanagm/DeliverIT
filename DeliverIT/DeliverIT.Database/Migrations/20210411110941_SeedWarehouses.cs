using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class SeedWarehouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 645, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 645, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 644, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 644, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 9, 40, 646, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "AddressId", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[,]
                {
                    { new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"), new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"), new DateTime(2021, 4, 11, 11, 9, 40, 647, DateTimeKind.Utc).AddTicks(806), null, null, null },
                    { new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"), new Guid("36049406-10ba-499d-916b-063422046239"), new DateTime(2021, 4, 11, 11, 9, 40, 647, DateTimeKind.Utc).AddTicks(393), null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36049406-10ba-499d-916b-063422046239"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 548, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 548, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 548, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 548, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 11, 7, 18, 550, DateTimeKind.Utc).AddTicks(3364));
        }
    }
}
