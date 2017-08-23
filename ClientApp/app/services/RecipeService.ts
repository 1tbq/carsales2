import { Injectable, Inject } from '@angular/core'
import { Http } from "@angular/http";
import 'rxjs/add/operator/map';
@Injectable()

export class RecipeService {
    constructor(private http: Http, @Inject('ORIGIN_URL') public originUrl: string) { }

    getRecipes() {
        return this.http.get(this.originUrl +'/api/recipes')
            .map(res => res.json());
    }
}