using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchemyUI : MonoBehaviour
{
   
    public Transform recipesParent; 
    public GameObject alchemyWindow;
    private List<Recipe> recipesList;
    public Button alchemyButton;
    RecipeSlot[] slots;
    void Start()
    {
        //парсим json 
        //что-то здесь у меня не получилось в свой класс засунуть json с вложенными списками
        TextAsset jsonRecipesData = Resources.Load<TextAsset>("Recipes");
        ArrayRecipeData loadedRecipeData = JsonUtility.FromJson<ArrayRecipeData>(jsonRecipesData.text);
        Debug.Log($"GameHandler: {jsonRecipesData}");
        recipesList = loadedRecipeData.recipesList;
        // return loadedRecipeData.recipesList;
        // recipesList = GameHandler.instance.FillRecipes();
        //Debug.Log($"Alchrmy: {GameHandler.instance.FillRecipes()}");
        FillRecipesUI();
    }

 
    //Открытие-закрытие окна Алхимии
    public void showCloseAlchemyWindow ()
    {
        alchemyWindow.SetActive(!alchemyWindow.activeSelf);
    }
    //Заполнение полей рецептов (заготовка)
    public void FillRecipesUI()
    {
        slots = recipesParent.GetComponentsInChildren<RecipeSlot>();
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < recipesList.Count)
            {
                slots[i].Add(recipesList[i].itemID, recipesList[i].amount);
                Debug.Log($"Alchemy: {recipesList[i].itemID}");
            }
            else
            {
           //     slots[i].ClearSlot();
            }
        }
    }
    //Не разобраля до конца с Serializable
    [Serializable]
    public class ArrayRecipeData
    {
        public List<Recipe> recipesList;
    }
    [Serializable]
    public class Recipe
    {
        public string itemID;
        public int amount;
        public int price;
        public List<InventoryItem> ingredients;
    }
    [Serializable]
    public class InventoryItem
    {
        public string itemID;
        public int amount;

        public InventoryItem()
        {
            this.itemID = null;
            this.amount = 0;
        }
        public InventoryItem(string itemID, int amount)
        {
            this.itemID = itemID;
            this.amount = amount;
        }
    }


}
