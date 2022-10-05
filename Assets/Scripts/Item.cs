
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemID = null;
    new public string name = "New Item";
    public int amount = 0;
    public Sprite icon = null;
    public bool isDefaultItem = false;

}
