using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    
    void Awake()
    {
        if (instance !=null)
        {
            Debug.LogWarning("Найено больше одного примера инвентаря");
            return;
        }
        instance = this;
    }
    #endregion
    
    
    public delegate void OnItemChanged();
    public OnItemChanged OnItemChangedCallback;
    public List<Item> items = new List<Item>();
    
    public void Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            items.Add(item);
            if (OnItemChangedCallback != null)
                OnItemChangedCallback.Invoke();
        }
    }
    
    public void Remove(Item item)
    {
        items.Remove(item);
        if (OnItemChangedCallback != null)
            OnItemChangedCallback.Invoke();
    }
}