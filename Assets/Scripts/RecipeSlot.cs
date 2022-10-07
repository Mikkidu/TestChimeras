using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecipeSlot : MonoBehaviour
{
    Recipe recipe;
    public InventorySlot recipeIcon;
    public GameObject recipeName, createPrice, recipeItems;
    void Start()
    {
       
    }
    
    public void Add(Recipe recipe)
    {
        this.recipe = recipe;
        Debug.Log($"RecipeSlot: {recipe.amount}");
        //recipe.itemID = itemID;
        recipeIcon.AddItem(recipe.itemID, recipe.amount);
        recipeName.GetComponent<TMP_Text>().text = Database.GetNameByID(recipe.itemID);
        Debug.Log($"RecipeSlot: {recipe.itemID}");
    }
}
