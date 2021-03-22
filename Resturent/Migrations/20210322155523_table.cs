using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Resturent.Migrations
{
    public partial class table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Config");

            migrationBuilder.RenameIndex(
                name: "UQ__User__C9F28456750598BE",
                schema: "Account",
                table: "User",
                newName: "UQ__User__C9F28456FA872635");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                schema: "Account",
                table: "User",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdmin",
                schema: "Account",
                table: "User",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "Account",
                table: "User",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Tables",
                schema: "Config",
                columns: table => new
                {
                    TableID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    TableName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TableDesc = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    eDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    mDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableID);
                    table.ForeignKey(
                        name: "FK__Tables__UserId__1F63A897",
                        column: x => x.UserId,
                        principalSchema: "Account",
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tables_UserId",
                schema: "Config",
                table: "Tables",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UQ__Tables__733652EE38157352",
                schema: "Config",
                table: "Tables",
                column: "TableName",
                unique: true,
                filter: "[TableName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tables",
                schema: "Config");

            migrationBuilder.RenameIndex(
                name: "UQ__User__C9F28456FA872635",
                schema: "Account",
                table: "User",
                newName: "UQ__User__C9F28456750598BE");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                schema: "Account",
                table: "User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "((0))");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdmin",
                schema: "Account",
                table: "User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "((0))");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "Account",
                table: "User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "((0))");
        }
    }
}
