using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookbook.Migrations
{
    /// <inheritdoc />
    public partial class xx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_KindOfDiets_KindOfDietId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_KindOfDishes_KindOfDishesId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Dishes_DishesId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_KindOfDietId",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_KindOfDishesId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "KindOfDietId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "KindOfDishesId",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "DishesId",
                table: "KindOfDishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DishesId",
                table: "KindOfDiets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "DishesId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KindOfDishes_DishesId",
                table: "KindOfDishes",
                column: "DishesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KindOfDiets_DishesId",
                table: "KindOfDiets",
                column: "DishesId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Dishes_DishesId",
                table: "Ingredients",
                column: "DishesId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KindOfDiets_Dishes_DishesId",
                table: "KindOfDiets",
                column: "DishesId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KindOfDishes_Dishes_DishesId",
                table: "KindOfDishes",
                column: "DishesId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Dishes_DishesId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_KindOfDiets_Dishes_DishesId",
                table: "KindOfDiets");

            migrationBuilder.DropForeignKey(
                name: "FK_KindOfDishes_Dishes_DishesId",
                table: "KindOfDishes");

            migrationBuilder.DropIndex(
                name: "IX_KindOfDishes_DishesId",
                table: "KindOfDishes");

            migrationBuilder.DropIndex(
                name: "IX_KindOfDiets_DishesId",
                table: "KindOfDiets");

            migrationBuilder.DropColumn(
                name: "DishesId",
                table: "KindOfDishes");

            migrationBuilder.DropColumn(
                name: "DishesId",
                table: "KindOfDiets");

            migrationBuilder.AlterColumn<int>(
                name: "DishesId",
                table: "Ingredients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KindOfDietId",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KindOfDishesId",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_KindOfDietId",
                table: "Dishes",
                column: "KindOfDietId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_KindOfDishesId",
                table: "Dishes",
                column: "KindOfDishesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_KindOfDiets_KindOfDietId",
                table: "Dishes",
                column: "KindOfDietId",
                principalTable: "KindOfDiets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_KindOfDishes_KindOfDishesId",
                table: "Dishes",
                column: "KindOfDishesId",
                principalTable: "KindOfDishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Dishes_DishesId",
                table: "Ingredients",
                column: "DishesId",
                principalTable: "Dishes",
                principalColumn: "Id");
        }
    }
}
