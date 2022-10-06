using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Класс предметов в инвентаре
class InventoryItem
    {
        public string itemID;
        public int amount;

        public InventoryItem()
        {
            this.itemID = null;
            this.amount = 0;
        }
        public InventoryItem(string itemID, int amount)
        {
            this.itemID = itemID;
            this.amount = amount;
        }
    }
