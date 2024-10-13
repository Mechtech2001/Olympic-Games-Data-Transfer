using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olympic_Games_Data_Transfer.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countrys_Events_eventsEventID",
                table: "Countrys");

            migrationBuilder.DropIndex(
                name: "IX_Countrys_eventsEventID",
                table: "Countrys");

            migrationBuilder.DropColumn(
                name: "eventsEventID",
                table: "Countrys");

            migrationBuilder.AddColumn<string>(
                name: "EventID",
                table: "Countrys",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "austria",
                column: "EventID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "brazil",
                column: "EventID",
                value: "summer olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "britain",
                column: "EventID",
                value: "winter olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "canada",
                column: "EventID",
                value: "winter olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "china",
                column: "EventID",
                value: "summer olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "cyprus",
                column: "EventID",
                value: "youth olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "finland",
                column: "EventID",
                value: "youth olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "france",
                column: "EventID",
                value: "youth olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "germany",
                column: "EventID",
                value: "summer olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "italy",
                column: "EventID",
                value: "winter olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "jamaica",
                column: "EventID",
                value: "winter olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "japan",
                column: "EventID",
                value: "winter olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "mexico",
                column: "EventID",
                value: "summer olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "netherlands",
                column: "EventID",
                value: "summer olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "pakistan",
                column: "EventID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "portugal",
                column: "EventID",
                value: "youth olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "russia",
                column: "EventID",
                value: "youth olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "slovakia",
                column: "EventID",
                value: "youth olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "sweden",
                column: "EventID",
                value: "winter olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "thailand",
                column: "EventID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "ukraine",
                column: "EventID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "uruguay",
                column: "EventID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "usa",
                column: "EventID",
                value: "summer olympics");

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "zimbabwe",
                column: "EventID",
                value: "paralympics");

            migrationBuilder.CreateIndex(
                name: "IX_Countrys_EventID",
                table: "Countrys",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_Countrys_Events_EventID",
                table: "Countrys",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "EventID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countrys_Events_EventID",
                table: "Countrys");

            migrationBuilder.DropIndex(
                name: "IX_Countrys_EventID",
                table: "Countrys");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "Countrys");

            migrationBuilder.AddColumn<string>(
                name: "eventsEventID",
                table: "Countrys",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "austria",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "brazil",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "britain",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "canada",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "china",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "cyprus",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "finland",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "france",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "germany",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "italy",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "jamaica",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "japan",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "mexico",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "netherlands",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "pakistan",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "portugal",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "russia",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "slovakia",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "sweden",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "thailand",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "ukraine",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "uruguay",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "usa",
                column: "eventsEventID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "zimbabwe",
                column: "eventsEventID",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Countrys_eventsEventID",
                table: "Countrys",
                column: "eventsEventID");

            migrationBuilder.AddForeignKey(
                name: "FK_Countrys_Events_eventsEventID",
                table: "Countrys",
                column: "eventsEventID",
                principalTable: "Events",
                principalColumn: "EventID");
        }
    }
}
