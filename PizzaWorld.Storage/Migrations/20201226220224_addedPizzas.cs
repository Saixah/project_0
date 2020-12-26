using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storage.Migrations
{
    public partial class addedPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445894333545659L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445894333547564L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445894333547596L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445894333533684L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445894333535166L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445894333535181L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445894333535184L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445894333468394L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445894333513837L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445894333530904L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445894333532193L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445894333532209L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445894333532213L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445894333532216L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445894333532233L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { 637445953439884051L, "Three" },
                    { 637445953439946302L, null },
                    { 637445953439950949L, null },
                    { 637445953439952779L, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445953439884051L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445953439946302L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445953439950949L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445953439952779L);

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445894333545659L, "Thin", 2m },
                    { 637445894333547564L, "Thick", 3m },
                    { 637445894333547596L, "Stuffed", 5m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445894333533684L, "Small", 12m },
                    { 637445894333535166L, "Medium", 16m },
                    { 637445894333535181L, "Large", 22m },
                    { 637445894333535184L, "X-Large", 28m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { 637445894333468394L, "One" },
                    { 637445894333513837L, "Two" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityId", "APizzaModelEntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445894333530904L, null, "Pepperoni", 2m },
                    { 637445894333532193L, null, "Pineapple", 6m },
                    { 637445894333532209L, null, "Bacon", 3m },
                    { 637445894333532213L, null, "Gold", 100m },
                    { 637445894333532216L, null, "Jalapenos", 60m },
                    { 637445894333532233L, null, "Cheese", 1m }
                });
        }
    }
}
