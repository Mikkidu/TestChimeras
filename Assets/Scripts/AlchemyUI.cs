using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class AlchemyUI : MonoBehaviour
{
   
    public Transform recipesParent; 
    public GameObject alchemyWindow;
    private List<Recipe> recipesList;
    public Recipe recipe;
    public Button alchemyButton;
    RecipeSlot[] slots;
    void Start()
    {
        
    }
    //Открытие-закрытие окна Алхимии
    public void showCloseAlchemyWindow ()
    {
        alchemyWindow.SetActive(!alchemyWindow.activeSelf);
        recipesList = GameHandler.instance.ParsRecipes();
        FillRecipesUI();
    }
    //Заполнение полей рецептов (заготовка)
    public void FillRecipesUI()
    {
        slots = recipesParent.GetComponentsInChildren<RecipeSlot>();
        Debug.Log($"Alchemy Fill: {recipesList[0].itemID}");
        slots[0].Add(recipesList[0]);
        // for (int i = 0; i < slots.Length; i++)
        // {
        //     if (i < recipesList.Count)
        //     {
        //         slots[i].Add(recipesList[i].itemID, recipesList[i].amount);
        //         Debug.Log($"Alchemy: {recipesList[i].itemID}");
        //     }
        //     else
        //     {
        //    //     slots[i].ClearSlot();
        //     }
        // }
    }

}
