using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> itemList = new List<Item>();
    public GameObject inventoryCanvas;
    public Transform ItemContent;
    public GameObject InventoryItem;
    void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        Escape();
    }
    private void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inventoryCanvas.SetActive(false);
        }
    }
    public void AddItem(Item item)
    {
        itemList.Add(item);
        if (inventoryCanvas.activeSelf == true)
            ListItem();
    }
    public void RemoveItem(Item item)
    {
        itemList.Remove(item);
        if (inventoryCanvas.activeSelf == true)
            ListItem();
    }
    public void ListItem()
    {
        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        foreach(var item in itemList)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }
    }
}
