import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public recipes: Recipe[];

  //TODO move fetching data logic to RecipeService
  //TODO move it to home page
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Recipe[]>(baseUrl + 'api/recipes').subscribe(result => {
      this.recipes = result;
    }, error => console.error(error));
  }
}

interface Recipe {
  recipeId: number;
  dish: string;
  description: string;
  minutesToPrepare: number;
  qualityStars: number;
}
