using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alchemy : MonoBehaviour
{
     #region Singleton
    public static Alchemy instance;
    
    void Awake()
    {
        if (instance !=null)
        {
            Debug.LogWarning("Найено больше одного примера списка рецептов");
            return;
        }
        instance = this;
    }
    #endregion

    
    List<Recipe> recipesList;
    //Принимаем список рецептов для хранения
    public void FillRecipes(List<Recipe> newRecipesList)
    {
        recipesList = newRecipesList;
    }
    //Выдаём список рецептов
    public List<Recipe> GetRecipes()
    {
        return recipesList;
    }

}
