using Microsoft.EntityFrameworkCore.Migrations;

namespace Pr7.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Firma = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Speed = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bodys",
                columns: table => new
                {
                    BodyColor = table.Column<string>(nullable: true),
                    BodyWeight = table.Column<double>(nullable: false),
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AutoId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodys", x => x.AutoId);
                    table.ForeignKey(
                        name: "FK_Bodys_Autos_AutoId1",
                        column: x => x.AutoId1,
                        principalTable: "Autos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    Price = table.Column<double>(nullable: false),
                    ColorDoor = table.Column<string>(nullable: true),
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AutoId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doors", x => x.AutoId);
                    table.ForeignKey(
                        name: "FK_Doors_Autos_AutoId1",
                        column: x => x.AutoId1,
                        principalTable: "Autos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Power = table.Column<double>(nullable: false),
                    Volume = table.Column<double>(nullable: false),
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AutoId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.AutoId);
                    table.ForeignKey(
                        name: "FK_Engines_Autos_AutoId1",
                        column: x => x.AutoId1,
                        principalTable: "Autos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wheels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Diameter = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    WheelManufacturer = table.Column<string>(nullable: true),
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AutoId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheels", x => x.AutoId);
                    table.ForeignKey(
                        name: "FK_Wheels_Autos_AutoId1",
                        column: x => x.AutoId1,
                        principalTable: "Autos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bodys_AutoId1",
                table: "Bodys",
                column: "AutoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Doors_AutoId1",
                table: "Doors",
                column: "AutoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_AutoId1",
                table: "Engines",
                column: "AutoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_AutoId1",
                table: "Wheels",
                column: "AutoId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bodys");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Wheels");

            migrationBuilder.DropTable(
                name: "Autos");
        }
    }
}
