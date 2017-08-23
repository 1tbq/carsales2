import { Component, EventEmitter, Output } from '@angular/core'
import { Recipe } from "./recipe";
import { RecipeService } from "../../services/RecipeService";

@Component({
    selector: 'recipe-list-item',
    templateUrl: 'recipe-list.component.html'
})
export class RecipeListComponent {
   @Output() recipes: Recipe[];

  
    
    
    constructor(private recipeService: RecipeService) { }

    ngOnInit() {
        this.recipeService.getRecipes().subscribe(recipes =>
            this.recipes = recipes
  
        );
    }
    add() {
        this.recipes.push({
            name:'Sabzi-Paluo',description:'something-tasty'
        });
    }

    
}