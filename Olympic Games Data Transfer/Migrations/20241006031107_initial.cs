using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Olympic_Games_Data_Transfer.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    eventsEventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    flag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countrys_Events_eventsEventID",
                        column: x => x.eventsEventID,
                        principalTable: "Events",
                        principalColumn: "EventID");
                    table.ForeignKey(
                        name: "FK_Countrys_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID");
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventID", "EventName" },
                values: new object[,]
                {
                    { "paralympics", "Paralympic Games" },
                    { "summer olympics", "Summer Olympics" },
                    { "winter olympics", "Winter Olympics" },
                    { "youth olympics", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "SportName", "category" },
                values: new object[,]
                {
                    { "archery", "Archery", "Indoor" },
                    { "bobsleigh", "Bobsleigh", "Outdoor" },
                    { "breakdancing", "Breakdancing", "Indoor" },
                    { "canoe sprint", "Canoe Sprint", "Outdoor" },
                    { "curling", "Curling", "Indoor" },
                    { "cycling", "Cycling", "Outdoor" },
                    { "diving", "Diving", "Indoor" },
                    { "skatebording", "Skatebording", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "CountryID", "CountryName", "SportID", "eventsEventID", "flag" },
                values: new object[,]
                {
                    { "austria", "Austria", "canoe sprint", null, "austria.png" },
                    { "brazil", "Brazil", "cycling", null, "brazil.png" },
                    { "britain", "Great Britain", "curling", null, "britain.png" },
                    { "canada", "Canada", "curling", null, "canada.png" },
                    { "china", "China", "diving", null, "china.png" },
                    { "cyprus", "Cyprus", "breakdancing", null, "cyprus.png" },
                    { "finland", "Finland", "skatebording", null, "finland.png" },
                    { "france", "France", "breakdancing", null, "france.png" },
                    { "germany", "Germany", "diving", null, "germany.png" },
                    { "italy", "Italy", "bobsleigh", null, "italy.png" },
                    { "jamaica", "Jamaica", "bobsleigh", null, "jamaica.png" },
                    { "japan", "Japan", "bobsleigh", null, "japan.png" },
                    { "mexico", "Mexico", "diving", null, "mexico.png" },
                    { "netherlands", "Netherlands", "cycling", null, "netherlands.png" },
                    { "pakistan", "Pakistan", "canoe sprint", null, "pakistan.png" },
                    { "portugal", "Portugal", "skatebording", null, "portugal.png" },
                    { "russia", "Russia", "breakdancing", null, "russia.png" },
                    { "slovakia", "Slovakia", "skatebording", null, "slovakia.png" },
                    { "sweden", "Sweden", "curling", null, "sweden.png" },
                    { "thailand", "Thailand", "archery", null, "thailand.png" },
                    { "ukraine", "Ukraine", "archery", null, "ukraine.png" },
                    { "uruguay", "Uruguay", "archery", null, "uruguay.png" },
                    { "usa", "USA", "cycling", null, "usa.png" },
                    { "zimbabwe", "Zimbabwe", "canoe sprint", null, "zimbabwe.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countrys_eventsEventID",
                table: "Countrys",
                column: "eventsEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Countrys_SportID",
                table: "Countrys",
                column: "SportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
