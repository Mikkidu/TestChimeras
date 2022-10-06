using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Database : MonoBehaviour
{
    
    public ItemDatabase items;
    private static Database instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static Item GetItemByID(string itemID)
    {
        //Debug.Log($"database: {itemID}");
        return instance.items.allItems.FirstOrDefault(i => i.itemID == itemID);
    }

    public static Sprite GetSpriteByID(string itemID)
    {
        return instance.items.allItems.FirstOrDefault(i => i.itemID == itemID).icon;
    }
}
