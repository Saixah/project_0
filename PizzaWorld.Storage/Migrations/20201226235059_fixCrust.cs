using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storage.Migrations
{
    public partial class fixCrust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Crust",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637446018589755482L, "Thin", 2m },
                    { 637446018589757361L, "Thick", 3m },
                    { 637446018589757390L, "Stuffed", 5m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "EntityId", "name", "price" },
                values: new object[,]
                {
                    { 637446018589749901L, "Small", 12m },
                    { 637446018589752587L, "Medium", 16m },
                    { 637446018589752625L, "Large", 22m },
                    { 637446018589752634L, "X-Large", 28m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { 637446018589630847L, "One" },
                    { 637446018589714609L, "Two" },
                    { 637446018589714695L, "Three" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityId", "APizzaModelEntityId", "name", "price" },
                values: new object[,]
                {
                    { 637446018589741957L, null, "Pepperoni", 2m },
                    { 637446018589745999L, null, "Pineapple", 6m },
                    { 637446018589746051L, null, "Bacon", 3m },
                    { 637446018589746060L, null, "Gold", 100m },
                    { 637446018589746067L, null, "Jalapenos", 60m },
                    { 637446018589746102L, null, "Cheese", 1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637446018589755482L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637446018589757361L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 637446018589757390L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637446018589749901L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637446018589752587L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637446018589752625L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: 637446018589752634L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637446018589630847L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637446018589714609L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637446018589714695L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637446018589741957L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637446018589745999L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637446018589746051L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637446018589746060L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637446018589746067L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityId",
                keyValue: 637446018589746102L);

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
    }
}
