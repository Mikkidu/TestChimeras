
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    Inventory inventory;
    InventorySlot[] slots;
    bool i = true;
    public GameObject gaha;
    
    void Start()
    {
        inventory = Inventory.instance;
        inventory.OnItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        
        Debug.Log($"InventoryUI: {slots.Length}");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (i)
        {
            i = false;
            gaha.GetComponent<GameHandler>().FillInventory();
        }
    }

    void UpdateUI()
    {
        string[] itemsID = inventory.GetItemsID();
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < itemsID.Length)
            {
                slots[i].AddItem(itemsID[i], inventory.GetAmountByID(itemsID[i]));
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
        //Debug.Log("UPDATING UI");
    }
}
