using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storage.Migrations
{
    public partial class reupload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { 637445955507732380L, "Thin", 2m },
                    { 637445955507733474L, "Thick", 3m },
                    { 637445955507733487L, "Stuffed", 5m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445955507719738L, "Small", 12m },
                    { 637445955507721598L, "Medium", 16m },
                    { 637445955507721616L, "Large", 22m },
                    { 637445955507721620L, "X-Large", 28m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { 637445955507658158L, "One" },
                    { 637445955507699445L, "Two" },
                    { 637445955507699492L, "Three" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityId", "APizzaModelEntityId", "name", "price" },
                values: new object[,]
                {
                    { 637445955507716691L, null, "Pepperoni", 2m },
                    { 637445955507718156L, null, "Pineapple", 6m },
                    { 637445955507718174L, null, "Bacon", 3m },
                    { 637445955507718177L, null, "Gold", 100m },
                    { 637445955507718181L, null, "Jalapenos", 60m },
                    { 637445955507718201L, null, "Cheese", 1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445955507732380L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445955507733474L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637445955507733487L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445955507719738L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445955507721598L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445955507721616L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637445955507721620L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445955507658158L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445955507699445L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637445955507699492L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445955507716691L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445955507718156L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445955507718174L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445955507718177L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445955507718181L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637445955507718201L);

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
    }
}
