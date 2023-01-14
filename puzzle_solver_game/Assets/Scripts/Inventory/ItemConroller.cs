using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemConroller : MonoBehaviour
{
    public Item item;

    public void RemoveItem()
    {
        InventoryManager.Instance.RemoveItem(item);
        Destroy(gameObject);
    }
    public void AddItem(Item newItem)
    {
        item = newItem;
    }
}
 