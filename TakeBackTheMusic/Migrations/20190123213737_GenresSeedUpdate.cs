using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TakeBackTheMusic.Migrations
{
    public partial class GenresSeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GenreName",
                table: "Genre",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GenreDescription",
                table: "Genre",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 1,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 620, DateTimeKind.Local).AddTicks(2413), new DateTime(2019, 1, 23, 16, 37, 37, 622, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 2,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1390), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 3,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1424), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 4,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1433), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 5,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1439), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 6,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1446), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 7,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1452), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 8,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1457), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 9,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1463), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 10,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1468), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 11,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1542), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 12,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1550), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 13,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1555), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 14,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1563), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 15,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1568), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 16,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1574), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 17,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1579), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 18,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1585), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 19,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1592), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 20,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1598), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 21,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1604), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 22,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1611), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 23,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1617), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 24,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1627), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 25,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1634), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 26,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1642), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 27,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1649), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 28,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1657), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 29,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1664), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 30,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1671), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 31,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1678), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 32,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1683), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 33,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1689), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 34,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1694), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 35,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1700), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 36,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1707), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 37,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1713), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 38,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1718), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 39,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1724), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 40,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1729), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 41,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1736), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 42,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1741), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 43,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1746), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 44,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1752), new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1754) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GenreName",
                table: "Genre",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GenreDescription",
                table: "Genre",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 1,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 654, DateTimeKind.Local).AddTicks(5759), new DateTime(2019, 1, 23, 16, 27, 51, 656, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 2,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1387), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 3,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1420), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 4,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1427), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 5,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1435), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 6,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1442), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 7,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1448), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 8,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1454), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 9,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1461), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 10,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1467), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 11,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1473), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 12,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1479), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 13,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1486), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 14,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1494), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 15,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1500), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 16,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1506), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 17,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1512), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 18,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1518), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 19,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1525), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 20,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1531), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 21,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1538), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 22,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1544), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 23,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1550), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 24,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1558), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 25,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1564), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 26,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1570), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 27,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1576), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 28,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1583), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 29,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1590), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 30,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1596), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 31,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1603), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 32,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1611), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 33,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1618), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 34,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1624), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 35,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1631), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 36,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1640), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 37,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1646), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 38,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1653), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 39,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1659), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 40,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1666), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 41,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1672), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 42,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1679), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 43,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1685), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "GenreID",
                keyValue: 44,
                columns: new[] { "GenreDateAdded", "GenreUpdatedDate" },
                values: new object[] { new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1692), new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1695) });
        }
    }
}
