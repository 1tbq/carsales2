using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarSales2.Migrations
{
    public partial class SeedDatabaseInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Recipes (Name) Values('Pumkin-Halwa')");
            migrationBuilder.Sql("INSERT INTO Recipes (Name) Values('Carrot-Halwa')");
            migrationBuilder.Sql("INSERT INTO Recipes (Name) Values('Rice-Kheer')");

            migrationBuilder.Sql("INSERT INTO Ingredients (Name,RecipeId) Values('Candoli',(SELECT ID FROM Recipes WHERE Name ='Pumkin-Halwa'))");
            migrationBuilder.Sql("INSERT INTO Ingredients (Name,RecipeId) Values('Gajir',(SELECT ID FROM Recipes WHERE Name ='Carrot-Halwa'))");
            migrationBuilder.Sql("INSERT INTO Ingredients (Name,RecipeId) Values('Chawal',(SELECT ID FROM Recipes WHERE Name ='Rice-Kheer'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Recipes");
        }
    }
}
