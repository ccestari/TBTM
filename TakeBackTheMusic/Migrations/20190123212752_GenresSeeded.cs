using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TakeBackTheMusic.Migrations
{
    public partial class GenresSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenreName = table.Column<string>(nullable: true),
                    GenreDescription = table.Column<string>(nullable: true),
                    GenreDateAdded = table.Column<DateTime>(nullable: false),
                    GenreUpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreID);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreID", "GenreDateAdded", "GenreDescription", "GenreName", "GenreUpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 23, 16, 27, 51, 654, DateTimeKind.Local).AddTicks(5759), "", "Acoustic", new DateTime(2019, 1, 23, 16, 27, 51, 656, DateTimeKind.Local).AddTicks(9185) },
                    { 25, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1564), "", "Holiday", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1567) },
                    { 26, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1570), "", "House", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1573) },
                    { 27, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1576), "", "Indie", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1579) },
                    { 28, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1583), "", "Instrumental", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1586) },
                    { 29, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1590), "", "Jam", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1593) },
                    { 30, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1596), "", "Jazz", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1599) },
                    { 31, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1603), "", "Latin", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1606) },
                    { 32, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1611), "", "Metal", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1614) },
                    { 24, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1558), "", "Hip Hop", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1560) },
                    { 33, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1618), "", "Other", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1621) },
                    { 35, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1631), "", "Punk", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1634) },
                    { 36, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1640), "", "R&B/Soul", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1642) },
                    { 37, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1646), "", "Rap", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1649) },
                    { 38, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1653), "", "Reggae", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1655) },
                    { 39, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1659), "", "Rock", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1662) },
                    { 40, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1666), "", "Rockabilly", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1669) },
                    { 41, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1672), "", "Singer Songwriter", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1675) },
                    { 42, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1679), "", "Ska", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1682) },
                    { 34, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1624), "", "Pop", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1628) },
                    { 23, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1550), "", "Grime", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1553) },
                    { 22, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1544), "", "Funk", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1547) },
                    { 21, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1538), "", "Folk", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1541) },
                    { 2, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1387), "", "Alternative", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1400) },
                    { 3, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1420), "", "Ambient", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1423) },
                    { 4, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1427), "", "Americana", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1430) },
                    { 5, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1435), "", "Bluegrass", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1438) },
                    { 6, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1442), "", "Blues", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1445) },
                    { 7, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1448), "", "Bollywood/Tollywood", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1451) },
                    { 8, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1454), "", "Celtic", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1457) },
                    { 9, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1461), "", "Childrens", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1464) },
                    { 10, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1467), "", "Christian Rock", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1470) },
                    { 11, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1473), "", "Christian/Gospel", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1476) },
                    { 12, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1479), "", "Classical", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1482) },
                    { 13, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1486), "", "Comedy", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1490) },
                    { 14, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1494), "", "Country", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1496) },
                    { 15, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1500), "", "DJ", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1503) },
                    { 16, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1506), "", "Dance", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1509) },
                    { 17, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1512), "", "Dubstep", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1515) },
                    { 18, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1518), "", "EDM", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1521) },
                    { 19, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1525), "", "Electronica", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1528) },
                    { 20, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1531), "", "Experimental", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1534) },
                    { 43, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1685), "", "Spiritual", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1689) },
                    { 44, new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1692), "", "World", new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1695) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
