import { Component } from '@angular/core';
import { RecipeService } from "../../services/RecipeService";
import { Recipe } from "../recipes/recipe";

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {

    recipes: Recipe[];



    constructor(private recipeService: RecipeService) { }

    ngOnInit() {
        this.recipeService.getRecipes().subscribe(recipes =>
            this.recipes = recipes

        );
    }

   

}
