using System;

//Класс для хранения рецепта
[Serializable]
public class Recipe
{
    public string itemID;
    public int amount;
    public int price;
    public string ingredient1ItemID;
    public int ingredient1amount;
    public string ingredient2ItemID;
    public int ingredient2amount;
    public string ingredient3ItemID;
    public int ingredient3amount;

    public Recipe()
    {
        this.itemID = null;
        this.amount = 0;
        this.price = 0;
        this.ingredient1ItemID = null;
        this.ingredient1amount = 0;
        this.ingredient2ItemID = null;
        this.ingredient2amount = 0;
        this.ingredient3ItemID = null;
        this.ingredient3amount = 0;


    }
    public Recipe(
        string itemID, int amount, int price, string ingredient1ItemID,
        int ingredient1amount, string ingredient2ItemID, int ingredient2amount)
    {
        this.itemID = itemID;
        this.amount = amount;
        this.price = price;
        this.ingredient1ItemID = ingredient1ItemID;
        this.ingredient1amount = ingredient1amount;
        this.ingredient2ItemID = ingredient2ItemID;
        this.ingredient2amount = ingredient2amount;
        this.ingredient3ItemID = null;
        this.ingredient3amount = 0;
    }
    public Recipe(
        string itemID, int amount, int price, string ingredient1ItemID,
        int ingredient1amount, string ingredient2ItemID, int ingredient2amount, string ingredient3ItemID, int ingredient3amount)
    {
        this.itemID = itemID;
        this.amount = amount;
        this.price = price;
        this.ingredient1ItemID = ingredient1ItemID;
        this.ingredient1amount = ingredient1amount;
        this.ingredient2ItemID = ingredient2ItemID;
        this.ingredient2amount = ingredient2amount;
        this.ingredient3ItemID = ingredient3ItemID;
        this.ingredient3amount = ingredient3amount;
    }
}
