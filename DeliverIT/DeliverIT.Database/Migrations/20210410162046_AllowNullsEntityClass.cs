using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deliverit.Database.Migrations
{
    public partial class AllowNullsEntityClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Warehouses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Warehouses",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Warehouses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Status",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Status",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Status",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Shipments",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Shipments",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Shipments",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Parcels",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Parcels",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Parcels",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Countries",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Countries",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Countries",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Cities",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Cities",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Cities",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Category",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Category",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Category",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 10, 19, 20, 45, 978, DateTimeKind.Local).AddTicks(7470), null, null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 10, 19, 20, 45, 978, DateTimeKind.Local).AddTicks(7478), null, null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 10, 19, 20, 45, 978, DateTimeKind.Local).AddTicks(7392), null, null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 10, 19, 20, 45, 975, DateTimeKind.Local).AddTicks(8601), null, null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 10, 19, 20, 45, 980, DateTimeKind.Local).AddTicks(2575), null, null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 10, 19, 20, 45, 980, DateTimeKind.Local).AddTicks(3065), null, null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 10, 19, 20, 45, 980, DateTimeKind.Local).AddTicks(3039), null, null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 10, 19, 20, 45, 980, DateTimeKind.Local).AddTicks(3065), null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Warehouses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Warehouses",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Warehouses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Status",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Status",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Status",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Shipments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Shipments",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Shipments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Parcels",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Parcels",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Parcels",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Countries",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Cities",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Category",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Addresses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Addresses",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Addresses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 9, 20, 56, 6, 740, DateTimeKind.Local).AddTicks(5429), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 9, 20, 56, 6, 740, DateTimeKind.Local).AddTicks(5438), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 9, 20, 56, 6, 740, DateTimeKind.Local).AddTicks(5360), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 9, 20, 56, 6, 737, DateTimeKind.Local).AddTicks(1605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 9, 20, 56, 6, 742, DateTimeKind.Local).AddTicks(2272), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 9, 20, 56, 6, 742, DateTimeKind.Local).AddTicks(3348), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 9, 20, 56, 6, 742, DateTimeKind.Local).AddTicks(3330), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                columns: new[] { "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 9, 20, 56, 6, 742, DateTimeKind.Local).AddTicks(3356), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
