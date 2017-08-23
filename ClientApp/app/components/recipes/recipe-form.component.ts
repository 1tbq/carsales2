import { Component, OnInit, Input } from '@angular/core';
import { RecipeService } from "../../services/RecipeService";
import { Recipe } from "./recipe";

@Component({
    selector: 'recipe-form',
    templateUrl: './recipe-form.component.html'
})

export class RecipeFormComponent implements OnInit {

    recipes:Recipe[];
    constructor(private recipeService: RecipeService) { }

    ngOnInit() {
        this.recipeService.getRecipes().subscribe(recipes => 
            this.recipes = recipes
        );
    }

     
 }