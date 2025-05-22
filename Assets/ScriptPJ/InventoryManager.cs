using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public List<ItemData> inventoryList = new List<ItemData>();

    public void AddItem(ItemData item)
    {
        inventoryList.Add(item);
    }

    public int GetItemAmount(ItemData data)
    {
        int amount = 0;
        foreach (ItemData item in inventoryList)
        {
            if (item == data)
                amount++;
        }
        return amount;
    }
}
