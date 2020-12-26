using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storage.Migrations
{
    public partial class betterIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445890371640666L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445890371641571L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445890371641581L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445890371638528L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445890371639345L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445890371639356L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445890371639359L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445890371587508L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445890371622284L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445890371636337L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445890371637365L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445890371637376L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445890371637380L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445890371637384L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445890371637394L);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Crust",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445890371640666L, "Thin", 2m },
                    { 637445890371641571L, "Thick", 3m },
                    { 637445890371641581L, "Stuffed", 5m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445890371638528L, "Small", 12m },
                    { 637445890371639345L, "Medium", 16m },
                    { 637445890371639356L, "Large", 22m },
                    { 637445890371639359L, "X-Large", 28m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { 637445890371587508L, "One" },
                    { 637445890371622284L, "Two" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityId", "APizzaModelEntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445890371636337L, null, "Pepperoni", 2m },
                    { 637445890371637365L, null, "Pineapple", 6m },
                    { 637445890371637376L, null, "Bacon", 3m },
                    { 637445890371637380L, null, "Gold", 100m },
                    { 637445890371637384L, null, "Jalapenos", 60m },
                    { 637445890371637394L, null, "Cheese", 1m }
                });
        }
    }
}
