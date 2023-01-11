using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> itemList;
    public static Inventory Instance;
    void Awake()
    {
        Instance = this;
    }
    public void AddItem(Item item)
    {
        itemList.Add(item);
    }
    public void RemoveItem(Item item)
    {
        itemList.Remove(item);
    }
}
