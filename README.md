# Recipe Book

Welcome to our kitchen! 
The recipe book application is fairly basic right now, but we have great ideas for improving it.

**RecipeBook** is the main entry point to the recipe library. It has a few simple functions:
- *Save*: takes a recipe and saves it to the recipe collection.
This could be a new recipe or an update to an existing recipe.
- *Recall*: takes a string name and returns a saved recipe.
- *Make*: takes a string name for a recipe and deducts their amounts from the ingredients available in the ingredient store.
***
We're really pleased with the work that has been done so far, but the application still has a long way to go before its viable.

This is where we hope you can help out! Here's our TODO list based on feedback, in no particular order:

* Recipe names should be unique, regardless of case entered.
  * Right now, if I save "MASHED POTATOES", the system can't recall it if I enter "mashed potatoes", and it even lets me save the same recipe with the lower case name!
  * NOTE: IRecipeStore is the definition for an interface owned by the recipe data management team. We cannot change the interface without a lengthy discussion with them.  

* Recipes cannot be made if there is not enough of any ingredient called for 
  * Today, if I want to make my omelette recipe which calls for 3 eggs, but I only have 1, the system lets me make the omelette and the inventory app tells me I now have -2 eggs... crazy!
  * NOTE: IIngredientStore is the definition for an interface owned by the ingredient inventory application team. We've alerted them to this issue, but it could take a while. Assume we cannot touch it.