using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logic.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PicturePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theaters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GotWheelchairRamp = table.Column<bool>(type: "bit", nullable: false),
                    TotalSeats = table.Column<int>(type: "int", nullable: false),
                    OccupiedSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Theaters_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheaterId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Seat = table.Column<int>(type: "int", nullable: false),
                    Wheelchair = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Info", "Name", "PicturePath" },
                values: new object[,]
                {
                    { 1, "A Phoenix secretary embezzles $40,000 from her employer's client, goes on the run, and checks into a remote motel run by a young man under the domination of his mother. ", "Psycho", "Psycho - Poster.jpg" },
                    { 2, "A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point. ", "Get Out", "Get Out - Poster.jpg" },
                    { 3, "A family's serene beach vacation turns to chaos when their doppelgängers appear and begin to terrorize them.", "Us", "Us - Poster.jpg" },
                    { 4, "After a space merchant vessel receives an unknown transmission as a distress call, one of the crew is attacked by a mysterious life form and they soon realize that its life cycle has merely begun. ", "Alien", "Alien - Poster.jpg" },
                    { 5, "When Cecilia's abusive ex takes his own life and leaves her his fortune, she suspects his death was a hoax. As a series of coincidences turn lethal, Cecilia works to prove that she is being hunted by someone nobody can see. ", "The Invisible Man", "The Invisible Man - Poster.jpg" },
                    { 6, "In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing. ", "A Quiet Place", "A Quiet Place - Poster.jpg" },
                    { 7, "When a killer shark unleashes chaos on a beach community, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down. ", "Jaws", "Jaws - Poster.jpg" },
                    { 8, "A single mother and her child fall into a deep well of paranoia when an eerie children's book titled Mister Babadook manifests in their home. ", "The Babadook", "The Babadook - Poster.jpg" },
                    { 9, "A grieving family is haunted by tragic and disturbing occurrences. ", "Hereditary", "Hereditary - Poster.jpg" },
                    { 10, "Oskar, an overlooked and bullied boy, finds love and revenge through Eli, a beautiful but peculiar girl. ", "Let the right one in", "Let the Right One In - Poster.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Theaters",
                columns: new[] { "Id", "GotWheelchairRamp", "MovieId", "OccupiedSeats", "RoomNumber", "StartTime", "TotalSeats" },
                values: new object[,]
                {
                    { 1, false, 1, 0, 1, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, false, 6, 0, 5, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, true, 6, 0, 9, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 7, false, 7, 0, 7, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, false, 7, 0, 4, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, false, 7, 0, 2, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, false, 7, 0, 7, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 8, false, 8, 0, 8, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, false, 6, 0, 5, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, false, 8, 0, 3, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, false, 8, 0, 6, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, true, 9, 0, 9, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, false, 9, 0, 2, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, false, 9, 0, 4, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, false, 9, 0, 3, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, true, 10, 0, 10, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, false, 10, 0, 1, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, false, 8, 0, 1, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 6, false, 6, 0, 6, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, true, 5, 0, 10, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, false, 5, 0, 6, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, true, 1, 0, 10, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, false, 1, 0, 8, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, false, 1, 0, 5, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 2, false, 2, 0, 2, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, true, 2, 0, 9, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, false, 2, 0, 7, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, false, 2, 0, 4, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 3, false, 3, 0, 3, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, false, 3, 0, 8, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, true, 3, 0, 10, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, false, 3, 0, 1, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 4, false, 4, 0, 4, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, false, 4, 0, 7, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, true, 4, 0, 9, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, false, 4, 0, 2, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 5, false, 5, 0, 5, new DateTime(2021, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, false, 5, 0, 6, new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, false, 10, 0, 3, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, false, 10, 0, 8, new DateTime(2021, 6, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Theaters_MovieId",
                table: "Theaters",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CustomerId",
                table: "Tickets",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TheaterId",
                table: "Tickets",
                column: "TheaterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Theaters");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
