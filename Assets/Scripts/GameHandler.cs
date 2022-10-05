using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ItemData loaadedItemdata = JsonUtility.FromJson<ItemData>(json);
        //File.WriteAllText(Application.dataPath + "Resorces\StartItems.json");
        TextAsset jsonItemData = Resources.Load<TextAsset>("StartItems");
        //string jsonItemData = File.ReadAllText(Application.dataPath + "/Resources/StartItems.json");
        Debug.Log(jsonItemData);
        ItemData loadedItemdata = JsonUtility.FromJson<ItemData>(jsonItemData.text);
        Debug.Log($"ItemID: {loadedItemdata.itemID}");
        Debug.Log($"Amount: {loadedItemdata.amount}");
    }

    public class ItemData
    {
        public string itemID;
        public int amount;
    }

    public class ArrayItemData
    {
        public List<ItemData> startItems;
    }

}
