using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizza.Migrations
{
    /// <inheritdoc />
    public partial class ModelRevisions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_toppings_pizzas_PizzaId",
                table: "toppings");

            migrationBuilder.DropIndex(
                name: "IX_toppings_PizzaId",
                table: "toppings");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "toppings");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "toppings",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Calories",
                table: "toppings",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "sauces",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegan",
                table: "sauces",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "pizzas",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PizzaTopping",
                columns: table => new
                {
                    ToppingsId = table.Column<int>(type: "INTEGER", nullable: false),
                    pizzasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaTopping", x => new { x.ToppingsId, x.pizzasId });
                    table.ForeignKey(
                        name: "FK_PizzaTopping_pizzas_pizzasId",
                        column: x => x.pizzasId,
                        principalTable: "pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaTopping_toppings_ToppingsId",
                        column: x => x.ToppingsId,
                        principalTable: "toppings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaTopping_pizzasId",
                table: "PizzaTopping",
                column: "pizzasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaTopping");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "toppings");

            migrationBuilder.DropColumn(
                name: "IsVegan",
                table: "sauces");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "toppings",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "toppings",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "sauces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "pizzas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_toppings_PizzaId",
                table: "toppings",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_toppings_pizzas_PizzaId",
                table: "toppings",
                column: "PizzaId",
                principalTable: "pizzas",
                principalColumn: "Id");
        }
    }
}
