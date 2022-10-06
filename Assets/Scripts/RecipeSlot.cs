using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeSlot : MonoBehaviour
{
    Recipe recipe;
    public InventorySlot recipeIcon;

    public void Add(string itemID, int amount)
    {
        recipe.itemID = itemID;
        recipeIcon.AddItem(recipe.itemID, recipe.amount);
        Debug.Log($"RecipeSlot: {recipe.itemID}");
    }
}
