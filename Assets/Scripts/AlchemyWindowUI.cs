using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyWindowUI : MonoBehaviour
{
    RecipeSlot[] slots;
    private List<Recipe> recipesList;
    public GameObject recipeAsset, tableRecipes;
    Inventory inventory;

    void Start()
    {
        inventory = Inventory.instance;
        inventory.OnItemChangedCallback += RefreshAmount;

    }
    
       //Заполнение полей рецептов (заготовка)
    public void FillRecipesUI()
    {
        recipesList = GameHandler.instance.ParsRecipes();
        slots = new RecipeSlot[recipesList.Count];
        //slots[0].Add(recipesList[0]);
        for (int i = 0; i < recipesList.Count; i++)
        {
            slots[i] = Instantiate(recipeAsset, tableRecipes.transform).GetComponent<RecipeSlot>();
            slots[i].Add(recipesList[i]);
        }
    }

    public void RefreshAmount()
    {
        for (int i = 0; i < recipesList.Count; i++)
        {
            slots[i].RefreshRecipe();
        }
    }

    public void CloseAlchemyWindow()
    {
        gameObject.SetActive(false);
        ClearAlchemyWindow();
    }

        private void ClearAlchemyWindow()
    {
         for (int i = 0; i < recipesList.Count; i++)
        {
            Destroy(slots[i].gameObject);
        }
        Debug.Log("Destroing");
    }

}
