using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();
 
        AddItem(new Item {ItemTypes = Item.ItemType.PassCodeHint, amount = 1});
        Debug.Log(itemList.Count);
    
    }

    public void AddItem(Item item){
        itemList.Add(item);
    }
}
