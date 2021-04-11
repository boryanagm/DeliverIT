using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class AddressWarehouseOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Addresses");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"), new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(7747), null, null, null, "Electronics" },
                    { new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"), new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(8177), null, null, null, "Clothing" },
                    { new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"), new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(8185), null, null, null, "Medical" },
                    { new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"), new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(8185), null, null, null, "Books" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 10, 49, 49, 12, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 10, 49, 49, 12, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 10, 49, 49, 12, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 10, 49, 49, 12, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("917f8117-d392-4f64-81fb-48415f80f77e"), new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(9647), null, null, null, "Preparing" },
                    { new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"), new DateTime(2021, 4, 11, 10, 49, 49, 15, DateTimeKind.Utc).AddTicks(51), null, null, null, "OnTheWay" },
                    { new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"), new DateTime(2021, 4, 11, 10, 49, 49, 15, DateTimeKind.Utc).AddTicks(60), null, null, null, "Completed" },
                    { new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"), new DateTime(2021, 4, 11, 10, 49, 49, 15, DateTimeKind.Utc).AddTicks(68), null, null, null, "Canceled" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("917f8117-d392-4f64-81fb-48415f80f77e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"));

            migrationBuilder.AddColumn<Guid>(
                name: "WarehouseId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 10, 20, 33, 36, 492, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 10, 20, 33, 36, 492, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 10, 20, 33, 36, 492, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 10, 20, 33, 36, 487, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 10, 20, 33, 36, 494, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 10, 20, 33, 36, 494, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 10, 20, 33, 36, 494, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                column: "CreatedOn",
                value: new DateTime(2021, 4, 10, 20, 33, 36, 494, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses",
                column: "AddressId",
                unique: true);
        }
    }
}
