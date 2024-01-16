using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bondr.Server.Migrations
{
    /// <inheritdoc />
    public partial class basedomainmodelupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Subscription",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Subscription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Subscription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Subscription",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Genre",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Genre",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Community",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Community",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Community",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Community",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a67ffa49-ef84-4dad-8753-c838dc5e7364", "AQAAAAIAAYagAAAAEBwPdLNQlAFZ+ll70A6F7DpVdg7FsFMNxL3md5PXMl3YCEF+V4ppQJGRm9jZ+3o7Cg==", "e679e1bc-47c8-4190-8ea0-b5e324b161ad" });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Subscription");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Subscription");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Subscription");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Subscription");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Community");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Community");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Community");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Community");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Comment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfabb152-6923-4af6-9253-b1fa9f059ba4", "AQAAAAIAAYagAAAAELw3X3hF9kbi0LrMkDJx1jPcDPZRfIyc3g92WPECqMXGk/pS13XFgqHALWfna0ZDxA==", "f09c4f67-a159-4dff-a810-27aa6c1c92ea" });
        }
    }
}
