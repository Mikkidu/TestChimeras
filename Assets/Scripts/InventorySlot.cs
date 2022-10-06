using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    Item item;
    public Text textAmount;
    public string slotItemID;

    public void AddItem(string itemID, int amount)
    {
        textAmount.text = amount.ToString();
        Debug.Log($"InventorySlot: {itemID}, {amount}");
        textAmount.enabled = true;
        textAmount.transform.parent.gameObject.GetComponent<Image>().enabled = true;

        slotItemID = itemID;

        icon.sprite = Database.GetSpriteByID(itemID);
        icon.enabled = true;
    }


    public void ClearSlot()
    {
        textAmount.text = null;
        textAmount.enabled = false;
        textAmount.transform.parent.gameObject.GetComponent<Image>().enabled = false;

        slotItemID = null;

        icon.sprite = null;
        icon.enabled = false;
    }
}
