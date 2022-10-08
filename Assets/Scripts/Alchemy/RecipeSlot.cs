using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecipeSlot : MonoBehaviour
{
    Recipe slotRecipe;
    public InventorySlot recipeIcon;
    public IngredientSlot[] ingredients;
    public GameObject secondPlus;
    public Button createButton;
    public TMP_Text textPrice, recipeName;
    int numbIngredients;

    //Заполнение данными рецепта
    public void Add(Recipe recipe)
    {
        slotRecipe = recipe;

        recipeIcon.AddItem(slotRecipe.itemID, slotRecipe.amount);

        recipeName.text = Database.GetNameByID(slotRecipe.itemID);

        textPrice.text = slotRecipe.price.ToString();

        ingredients[0].GetComponent<IngredientSlot>().AddItem(slotRecipe.ingredient1ItemID, slotRecipe.ingredient1amount);
        ingredients[1].GetComponent<IngredientSlot>().AddItem(slotRecipe.ingredient2ItemID, slotRecipe.ingredient2amount);

        if (slotRecipe.ingredient3ItemID == "")
        {
            ingredients[2].gameObject.SetActive(false);
            secondPlus.SetActive(false);
            numbIngredients = 2;
        }
        else
        {
            ingredients[2].GetComponent<IngredientSlot>().AddItem(slotRecipe.ingredient3ItemID, slotRecipe.ingredient3amount);
            numbIngredients = 3;
        }
        createButton.interactable = CheckAmountRecipe();
    }

    //Обновляем количество ингридиентов
    public void RefreshRecipe()
    {
        for (int i = 0; i < numbIngredients; i++)
        {
            ingredients[i].RefreshSlot();
        }
        createButton.interactable = CheckAmountRecipe();
    }

    //Проверяем выполнение требований рецепта
    public bool CheckAmountRecipe()
    {
        for (int i = 0; i < numbIngredients; i++)
        {
            if (!ingredients[i].CheckAmountIngredient())
            {
                return false;
            }
        }
        return true;
    }

    //Крафтим предмет рецепта
    public void CreateButton()
    {
        Inventory.instance.Add(slotRecipe.itemID, slotRecipe.amount);
        for (int i = 0; i < numbIngredients; i++)
        {
            Inventory.instance.Spend(ingredients[i].slotItemID, ingredients[i].required);
        }
    }
}
