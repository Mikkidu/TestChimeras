using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IngredientSlot : MonoBehaviour
{
    public string slotItemID;
    public int required;
    
    public void AddItem(string itemID, int amount)
    {
        slotItemID = itemID;
        required = amount;

        gameObject.GetComponentInChildren<TMP_Text>().enabled = true;
        Image icon =gameObject.GetComponentInChildren<Image>();
        RefreshSlot();

        icon.sprite = Database.GetSpriteByID(slotItemID);
        icon.enabled = true;
    }

    //Очищаем слот инвентаря
    public void ClearSlot()
    {
        TMP_Text textAmount =  gameObject.GetComponentInChildren<TMP_Text>();
        Image icon = gameObject.GetComponentInChildren<Image>();
        textAmount.text = null;
        textAmount.enabled = false;
 
        slotItemID = null;
        required = 0;

        icon.sprite = null;
        icon.enabled = false;
    }

    //Обновляем количество
    public void RefreshSlot()
    {
        TMP_Text textAmount =  gameObject.GetComponentInChildren<TMP_Text>();
        textAmount.text = $"{Inventory.instance.GetAmountByID(slotItemID)}/{required}";
        if (Inventory.instance.GetAmountByID(slotItemID) >= required)
        {
            textAmount.color = new Color(151f/255f, 98f/255f, 72f/255f);
        }
        else
        {
            textAmount.color = Color.red;
        }
    }
    public bool CheckAmountIngredient()
    {
        Debug.Log($"{slotItemID}: {required} {Inventory.instance.GetAmountByID(slotItemID)}");
        return required <= Inventory.instance.GetAmountByID(slotItemID);
    }

    
}
