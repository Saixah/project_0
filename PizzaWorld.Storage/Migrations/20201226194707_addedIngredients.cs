using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storage.Migrations
{
    public partial class addedIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637444023446912186L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637444023446976942L);

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445872262613129L, "Thin", 2m },
                    { 637445872262615412L, "Thick", 3m },
                    { 637445872262615444L, "Stuffed", 5m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445872262603294L, "Small", 12m },
                    { 637445872262607530L, "Medium", 16m },
                    { 637445872262607579L, "Large", 22m },
                    { 637445872262607586L, "X-Large", 28m }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityId", "APizzaModelEntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445872262524942L, null, "Pepperoni", 2m },
                    { 637445872262570665L, null, "Pineapple", 6m },
                    { 637445872262570742L, null, "Bacon", 3m },
                    { 637445872262570750L, null, "Gold", 100m },
                    { 637445872262570756L, null, "Jalapenos", 60m },
                    { 637445872262570774L, null, "Cheese", 1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445872262613129L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445872262615412L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445872262615444L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445872262603294L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445872262607530L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445872262607579L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445872262607586L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445872262524942L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445872262570665L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445872262570742L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445872262570750L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445872262570756L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445872262570774L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637444023446912186L, "One" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637444023446976942L, "Two" });
        }
    }
}
