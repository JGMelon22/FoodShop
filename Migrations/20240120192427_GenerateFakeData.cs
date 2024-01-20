using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodShop.Migrations
{
    /// <inheritdoc />
    public partial class GenerateFakeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "foods",
                columns: new[] { "food_id", "is_healthy", "food_name" },
                values: new object[,]
                {
                    { 1, (sbyte)1, "Unbranded Rubber Shirt" },
                    { 2, (sbyte)1, "Awesome Wooden Table" },
                    { 3, (sbyte)0, "Fantastic Fresh Pizza" },
                    { 4, (sbyte)1, "Refined Granite Shirt" },
                    { 5, (sbyte)1, "Practical Concrete Pizza" },
                    { 6, (sbyte)1, "Intelligent Metal Shirt" },
                    { 7, (sbyte)1, "Intelligent Plastic Chicken" },
                    { 8, (sbyte)1, "Licensed Plastic Pizza" },
                    { 9, (sbyte)1, "Intelligent Concrete Gloves" },
                    { 10, (sbyte)1, "Ergonomic Metal Shoes" },
                    { 11, (sbyte)1, "Unbranded Steel Chips" },
                    { 12, (sbyte)0, "Licensed Steel Ball" },
                    { 13, (sbyte)1, "Tasty Frozen Bacon" },
                    { 14, (sbyte)0, "Generic Soft Computer" },
                    { 15, (sbyte)0, "Incredible Frozen Soap" },
                    { 16, (sbyte)0, "Intelligent Wooden Mouse" },
                    { 17, (sbyte)0, "Generic Wooden Soap" },
                    { 18, (sbyte)0, "Ergonomic Concrete Hat" },
                    { 19, (sbyte)1, "Awesome Rubber Salad" },
                    { 20, (sbyte)0, "Rustic Concrete Keyboard" },
                    { 21, (sbyte)0, "Generic Frozen Chair" },
                    { 22, (sbyte)0, "Incredible Wooden Chips" },
                    { 23, (sbyte)1, "Sleek Soft Bike" },
                    { 24, (sbyte)1, "Handcrafted Cotton Bacon" },
                    { 25, (sbyte)1, "Gorgeous Wooden Tuna" },
                    { 26, (sbyte)0, "Refined Granite Cheese" },
                    { 27, (sbyte)1, "Tasty Frozen Car" },
                    { 28, (sbyte)1, "Rustic Granite Computer" },
                    { 29, (sbyte)1, "Awesome Rubber Shirt" },
                    { 30, (sbyte)0, "Generic Frozen Shoes" },
                    { 31, (sbyte)1, "Awesome Plastic Salad" },
                    { 32, (sbyte)0, "Incredible Metal Soap" },
                    { 33, (sbyte)1, "Gorgeous Fresh Tuna" },
                    { 34, (sbyte)0, "Licensed Rubber Shirt" },
                    { 35, (sbyte)1, "Small Soft Shirt" },
                    { 36, (sbyte)1, "Ergonomic Cotton Chicken" },
                    { 37, (sbyte)1, "Unbranded Concrete Shoes" },
                    { 38, (sbyte)0, "Refined Fresh Chair" },
                    { 39, (sbyte)0, "Practical Frozen Tuna" },
                    { 40, (sbyte)0, "Intelligent Steel Salad" },
                    { 41, (sbyte)0, "Unbranded Cotton Gloves" },
                    { 42, (sbyte)0, "Licensed Soft Ball" },
                    { 43, (sbyte)0, "Intelligent Cotton Ball" },
                    { 44, (sbyte)0, "Sleek Wooden Tuna" },
                    { 45, (sbyte)1, "Sleek Granite Car" },
                    { 46, (sbyte)0, "Tasty Frozen Keyboard" },
                    { 47, (sbyte)1, "Handmade Rubber Chicken" },
                    { 48, (sbyte)1, "Awesome Fresh Fish" },
                    { 49, (sbyte)0, "Intelligent Plastic Bacon" },
                    { 50, (sbyte)0, "Unbranded Concrete Table" }
                });

            migrationBuilder.InsertData(
                table: "typical_places",
                columns: new[] { "Id", "country_name" },
                values: new object[,]
                {
                    { 1, "El Salvador" },
                    { 2, "Cyprus" },
                    { 3, "Svalbard & Jan Mayen Islands" },
                    { 4, "Serbia" },
                    { 5, "Central African Republic" },
                    { 6, "American Samoa" },
                    { 7, "Norfolk Island" },
                    { 8, "Burkina Faso" },
                    { 9, "Bulgaria" },
                    { 10, "Saint Barthelemy" },
                    { 11, "Austria" },
                    { 12, "French Polynesia" },
                    { 13, "Sweden" },
                    { 14, "Malawi" },
                    { 15, "United States of America" },
                    { 16, "Netherlands" },
                    { 17, "Nauru" },
                    { 18, "Niue" },
                    { 19, "Dominica" },
                    { 20, "Barbados" },
                    { 21, "Sierra Leone" },
                    { 22, "Sao Tome and Principe" },
                    { 23, "Greece" },
                    { 24, "Albania" },
                    { 25, "Bahamas" },
                    { 26, "Saint Kitts and Nevis" },
                    { 27, "Saint Vincent and the Grenadines" },
                    { 28, "Turkey" },
                    { 29, "Nauru" },
                    { 30, "Western Sahara" },
                    { 31, "South Georgia and the South Sandwich Islands" },
                    { 32, "Slovenia" },
                    { 33, "Cuba" },
                    { 34, "Cocos (Keeling) Islands" },
                    { 35, "Nauru" },
                    { 36, "Hong Kong" },
                    { 37, "Sao Tome and Principe" },
                    { 38, "Malta" },
                    { 39, "New Zealand" },
                    { 40, "Palau" },
                    { 41, "Mauritania" },
                    { 42, "Guadeloupe" },
                    { 43, "Germany" },
                    { 44, "Tuvalu" },
                    { 45, "Latvia" },
                    { 46, "Seychelles" },
                    { 47, "Mozambique" },
                    { 48, "Macao" },
                    { 49, "Djibouti" },
                    { 50, "New Caledonia" }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "category_id", "food_id", "category_name" },
                values: new object[,]
                {
                    { 1, 16, "Fantastic Fresh Mouse" },
                    { 2, 20, "Refined Fresh Ball" },
                    { 3, 44, "Sleek Metal Pants" },
                    { 4, 25, "Small Frozen Chair" },
                    { 5, 44, "Gorgeous Soft Tuna" },
                    { 6, 26, "Tasty Soft Salad" },
                    { 7, 28, "Refined Cotton Chips" },
                    { 8, 15, "Handmade Soft Pizza" },
                    { 9, 31, "Handmade Cotton Towels" },
                    { 10, 26, "Sleek Cotton Cheese" },
                    { 11, 27, "Refined Wooden Chair" },
                    { 12, 40, "Tasty Frozen Chicken" },
                    { 13, 19, "Incredible Metal Sausages" },
                    { 14, 28, "Licensed Steel Salad" },
                    { 15, 19, "Rustic Cotton Computer" },
                    { 16, 27, "Handcrafted Plastic Gloves" },
                    { 17, 20, "Handmade Fresh Bacon" },
                    { 18, 42, "Generic Wooden Fish" },
                    { 19, 41, "Gorgeous Granite Shoes" },
                    { 20, 17, "Refined Soft Shoes" },
                    { 21, 27, "Small Granite Shirt" },
                    { 22, 21, "Ergonomic Soft Table" },
                    { 23, 49, "Rustic Metal Towels" },
                    { 24, 45, "Tasty Steel Towels" },
                    { 25, 13, "Rustic Soft Ball" },
                    { 26, 7, "Ergonomic Fresh Fish" },
                    { 27, 30, "Intelligent Cotton Bike" },
                    { 28, 2, "Tasty Plastic Mouse" },
                    { 29, 39, "Gorgeous Concrete Bacon" },
                    { 30, 4, "Unbranded Granite Hat" },
                    { 31, 5, "Licensed Plastic Pizza" },
                    { 32, 2, "Ergonomic Wooden Towels" },
                    { 33, 17, "Small Frozen Pizza" },
                    { 34, 14, "Refined Wooden Computer" },
                    { 35, 33, "Rustic Metal Mouse" },
                    { 36, 40, "Ergonomic Soft Hat" },
                    { 37, 32, "Unbranded Fresh Ball" },
                    { 38, 31, "Unbranded Steel Shirt" },
                    { 39, 15, "Intelligent Steel Tuna" },
                    { 40, 47, "Awesome Rubber Bacon" },
                    { 41, 24, "Awesome Metal Chair" },
                    { 42, 47, "Fantastic Steel Gloves" },
                    { 43, 39, "Rustic Frozen Pizza" },
                    { 44, 9, "Practical Granite Table" },
                    { 45, 40, "Incredible Fresh Hat" },
                    { 46, 31, "Small Frozen Ball" },
                    { 47, 12, "Handmade Plastic Chips" },
                    { 48, 38, "Fantastic Cotton Pants" },
                    { 49, 38, "Incredible Soft Sausages" },
                    { 50, 11, "Gorgeous Soft Pizza" }
                });

            migrationBuilder.InsertData(
                table: "foods_typical_places",
                columns: new[] { "food_id", "typical_place_id" },
                values: new object[,]
                {
                    { 3, 34 },
                    { 4, 8 },
                    { 7, 14 },
                    { 7, 15 },
                    { 9, 40 },
                    { 13, 12 },
                    { 13, 14 },
                    { 15, 2 },
                    { 15, 31 },
                    { 16, 42 },
                    { 17, 12 },
                    { 18, 28 },
                    { 19, 5 },
                    { 19, 21 },
                    { 20, 5 },
                    { 24, 7 },
                    { 24, 14 },
                    { 25, 26 },
                    { 26, 46 },
                    { 27, 43 },
                    { 30, 6 },
                    { 30, 18 },
                    { 30, 20 },
                    { 30, 45 },
                    { 31, 22 },
                    { 31, 39 },
                    { 32, 37 },
                    { 36, 18 },
                    { 37, 8 },
                    { 37, 30 },
                    { 37, 41 },
                    { 38, 2 },
                    { 38, 9 },
                    { 39, 1 },
                    { 39, 9 },
                    { 39, 11 },
                    { 39, 14 },
                    { 39, 22 },
                    { 39, 26 },
                    { 39, 47 },
                    { 39, 49 },
                    { 40, 36 },
                    { 43, 4 },
                    { 43, 30 },
                    { 45, 1 },
                    { 45, 4 },
                    { 46, 28 },
                    { 47, 18 },
                    { 48, 35 },
                    { 49, 49 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 9, 40 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 15, 31 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 16, 42 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 17, 12 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 18, 28 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 19, 21 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 24, 14 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 25, 26 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 26, 46 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 27, 43 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 30, 18 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 30, 20 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 30, 45 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 31, 22 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 31, 39 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 32, 37 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 36, 18 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 37, 8 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 37, 30 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 37, 41 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 38, 2 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 38, 9 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 39, 9 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 39, 11 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 39, 14 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 39, 22 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 39, 26 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 39, 47 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 39, 49 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 40, 36 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 43, 4 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 43, 30 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 45, 4 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 46, 28 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 47, 18 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 48, 35 });

            migrationBuilder.DeleteData(
                table: "foods_typical_places",
                keyColumns: new[] { "food_id", "typical_place_id" },
                keyValues: new object[] { 49, 49 });

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "foods",
                keyColumn: "food_id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "typical_places",
                keyColumn: "Id",
                keyValue: 49);
        }
    }
}
