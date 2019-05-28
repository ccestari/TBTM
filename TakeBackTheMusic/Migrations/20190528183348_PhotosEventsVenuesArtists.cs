using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TakeBackTheMusic.Migrations
{
    public partial class PhotosEventsVenuesArtists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerIDId = table.Column<string>(nullable: true),
                    ArtistCreateDate = table.Column<DateTime>(nullable: false),
                    ArtistDisplayName = table.Column<string>(maxLength: 150, nullable: false),
                    ArtistLink = table.Column<string>(maxLength: 150, nullable: false),
                    ArtistDesc = table.Column<string>(nullable: true),
                    IsPublic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistID);
                    table.ForeignKey(
                        name: "FK_Artists_AspNetUsers_OwnerIDId",
                        column: x => x.OwnerIDId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoID = table.Column<Guid>(nullable: false),
                    PhotoOwnerIDId = table.Column<string>(nullable: true),
                    PhotoFilePath = table.Column<string>(nullable: true),
                    PhotoCaption = table.Column<string>(nullable: true),
                    PhotoUploadTime = table.Column<DateTime>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoID);
                    table.ForeignKey(
                        name: "FK_Photos_AspNetUsers_PhotoOwnerIDId",
                        column: x => x.PhotoOwnerIDId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_OwnerIDId",
                table: "Artists",
                column: "OwnerIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PhotoOwnerIDId",
                table: "Photos",
                column: "PhotoOwnerIDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenreDateAdded = table.Column<DateTime>(nullable: false),
                    GenreDescription = table.Column<string>(maxLength: 256, nullable: true),
                    GenreName = table.Column<string>(maxLength: 50, nullable: true),
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
                    { 1, new DateTime(2019, 1, 23, 16, 37, 37, 620, DateTimeKind.Local).AddTicks(2413), "", "Acoustic", new DateTime(2019, 1, 23, 16, 37, 37, 622, DateTimeKind.Local).AddTicks(9025) },
                    { 25, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1634), "", "Holiday", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1638) },
                    { 26, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1642), "", "House", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1645) },
                    { 27, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1649), "", "Indie", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1653) },
                    { 28, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1657), "", "Instrumental", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1660) },
                    { 29, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1664), "", "Jam", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1667) },
                    { 30, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1671), "", "Jazz", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1674) },
                    { 31, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1678), "", "Latin", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1681) },
                    { 32, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1683), "", "Metal", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1686) },
                    { 24, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1627), "", "Hip Hop", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1630) },
                    { 33, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1689), "", "Other", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1692) },
                    { 35, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1700), "", "Punk", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1703) },
                    { 36, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1707), "", "R&B/Soul", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1710) },
                    { 37, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1713), "", "Rap", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1716) },
                    { 38, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1718), "", "Reggae", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1721) },
                    { 39, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1724), "", "Rock", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1726) },
                    { 40, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1729), "", "Rockabilly", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1732) },
                    { 41, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1736), "", "Singer Songwriter", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1738) },
                    { 42, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1741), "", "Ska", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1743) },
                    { 34, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1694), "", "Pop", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1697) },
                    { 23, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1617), "", "Grime", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1621) },
                    { 22, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1611), "", "Funk", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1614) },
                    { 21, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1604), "", "Folk", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1607) },
                    { 2, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1390), "", "Alternative", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1403) },
                    { 3, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1424), "", "Ambient", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1427) },
                    { 4, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1433), "", "Americana", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1436) },
                    { 5, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1439), "", "Bluegrass", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1442) },
                    { 6, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1446), "", "Blues", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1449) },
                    { 7, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1452), "", "Bollywood/Tollywood", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1455) },
                    { 8, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1457), "", "Celtic", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1460) },
                    { 9, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1463), "", "Childrens", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1465) },
                    { 10, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1468), "", "Christian Rock", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1470) },
                    { 11, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1542), "", "Christian/Gospel", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1546) },
                    { 12, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1550), "", "Classical", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1552) },
                    { 13, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1555), "", "Comedy", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1560) },
                    { 14, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1563), "", "Country", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1566) },
                    { 15, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1568), "", "DJ", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1571) },
                    { 16, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1574), "", "Dance", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1576) },
                    { 17, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1579), "", "Dubstep", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1582) },
                    { 18, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1585), "", "EDM", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1588) },
                    { 19, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1592), "", "Electronica", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1594) },
                    { 20, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1598), "", "Experimental", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1600) },
                    { 43, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1746), "", "Spiritual", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1749) },
                    { 44, new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1752), "", "World", new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1754) }
                });
        }
    }
}
