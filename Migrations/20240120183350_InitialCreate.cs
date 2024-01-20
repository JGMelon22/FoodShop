using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace FoodShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "foods",
                columns: table => new
                {
                    food_id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    food_name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    is_healthy = table.Column<bool>(type: "bool(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_food", x => x.food_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "typical_places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    country_name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_typical_place", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    food_id = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_category", x => x.category_id);
                    table.ForeignKey(
                        name: "fk_categories_foods",
                        column: x => x.food_id,
                        principalTable: "foods",
                        principalColumn: "food_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "foods_typical_places",
                columns: table => new
                {
                    food_id = table.Column<int>(type: "INT", nullable: false),
                    typical_place_id = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_foods_typical_places", x => new { x.food_id, x.typical_place_id });
                    table.ForeignKey(
                        name: "FK_foods_typical_places_typical_places_typical_place_id",
                        column: x => x.typical_place_id,
                        principalTable: "typical_places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_typical_places_food_typical_places",
                        column: x => x.food_id,
                        principalTable: "foods",
                        principalColumn: "food_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_categories_food_id",
                table: "categories",
                column: "food_id");

            migrationBuilder.CreateIndex(
                name: "idx_category_id",
                table: "categories",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "idx_food_id",
                table: "foods",
                column: "food_id");

            migrationBuilder.CreateIndex(
                name: "IX_foods_typical_places_typical_place_id",
                table: "foods_typical_places",
                column: "typical_place_id");

            migrationBuilder.CreateIndex(
                name: "idx_food_id_foods_typical_places",
                table: "foods_typical_places",
                column: "food_id");

            migrationBuilder.CreateIndex(
                name: "idx_typical_place_id",
                table: "typical_places",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "foods_typical_places");

            migrationBuilder.DropTable(
                name: "typical_places");

            migrationBuilder.DropTable(
                name: "foods");
        }
    }
}
