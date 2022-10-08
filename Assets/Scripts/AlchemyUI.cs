using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class AlchemyUI : MonoBehaviour
{
    public GameObject alchemyWindow, alchemyWindowAsset;
    
    //Открытие-закрытие окна Алхимии
    public void ShowAlchemyWindow()
    {
        if (alchemyWindow == null)
        {
            alchemyWindow = Instantiate(alchemyWindowAsset, transform);
        }
        alchemyWindow.SetActive(true);
        alchemyWindow.GetComponent<AlchemyWindowUI>().FillRecipesUI();
    }


}
