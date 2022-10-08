using System.Collections.Generic;
using UnityEngine;

public class AlchemyWindowUI : MonoBehaviour
{
    RecipeSlot[] slots;
    private List<Recipe> recipesList;
    public GameObject recipeAsset, tableRecipes;
    Inventory inventory;

    //Реагируем на изменения в инвентаре
    void Start()
    {
        inventory = Inventory.instance;
        inventory.OnItemChangedCallback += RefreshAmount;
    }

    //Заполнение списка рецептов
    public void FillRecipesUI()
    {
        recipesList = GameHandler.instance.ParsRecipes();
        slots = new RecipeSlot[recipesList.Count];
        for (int i = 0; i < recipesList.Count; i++)
        {
            slots[i] = Instantiate(recipeAsset, tableRecipes.transform).GetComponent<RecipeSlot>();
            slots[i].Add(recipesList[i]);
        }
    }

    //ПРоверяем количество предметов
    public void RefreshAmount()
    {
        for (int i = 0; i < recipesList.Count; i++)
        {
            slots[i].RefreshRecipe();
        }
    }
    //Закрываем окно Алхимии
    public void CloseAlchemyWindow()
    {
        gameObject.SetActive(false);
        ClearAlchemyWindow();
    }
    //Очищаем окно алхимии
    private void ClearAlchemyWindow()
    {
        for (int i = 0; i < recipesList.Count; i++)
        {
            Destroy(slots[i].gameObject);
        }
        recipesList = null;
    }

}
