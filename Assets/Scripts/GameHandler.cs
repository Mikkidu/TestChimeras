using System;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    #region Singleton
    public static GameHandler instance;
    
    void Awake()
    {
        if (instance !=null)
        {
            Debug.LogWarning("Найено больше одного примера загрузчика");
            return;
        }
        instance = this;
    }
    #endregion


    ArrayItemData loadedItemdata;
    //Для инвентаря сбор информации удался
    void Start()
    {
        TextAsset jsonItemData = Resources.Load<TextAsset>("StartItems");

        loadedItemdata = JsonUtility.FromJson<ArrayItemData>(jsonItemData.text);
        
    }
    //передаём стартовые предметы в инвентарь
    public void FillInventory()
    {
        //Debug.Log($"GameHandler: Fill");
        foreach (ItemData item in loadedItemdata.startItems)
        {
            Inventory.instance.Add(item.itemID, item.amount);
        }
    }
    //для списка рецептов не удался парс
    // public List<Recipe> FillRecipes()
    // {
    //     TextAsset jsonRecipesData = Resources.Load<TextAsset>("Recipes");
    //     ArrayRecipeData loadedRecipeData = JsonUtility.FromJson<ArrayRecipeData>(jsonRecipesData.text);
    //     Debug.Log($"GameHandler: {jsonRecipesData}");
    //     return loadedRecipeData.recipesList;
    // }
    
    [Serializable]
    class ItemData
    {
        public string itemID;
        public int amount;
    }
    [Serializable]
    class ArrayItemData
    {
        public List<ItemData> startItems;
    }

    // [Serializable]
    // public class ArrayRecipeData
    // {
    //     public List<Recipe> recipesList;
    // }
    


}
