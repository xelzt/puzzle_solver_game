using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public bool inTriger = false;
    public Item item;
    public GameObject gameObj;
    public Collider gameObjCollider;
    public Renderer gameObjRenderer;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTriger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTriger = false;
        }
    }
    void Start()
    {
        if (gameObj.name == "Nexus" | gameObj.name == "Nexus_to_input")
        {
            gameObjCollider = GetComponent<Collider>();
            gameObjRenderer = GetComponent<Renderer>();
        }
    }
    void Use()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTriger && !gameObjRenderer.enabled)
        {
            foreach (var invItem in InventoryManager.Instance.itemList)
            {
                if (invItem.itemName == item.itemName)
                {
                    InventoryManager.Instance.RemoveItem(item);
                    gameObjCollider.enabled = true;
                    gameObjRenderer.enabled = true;
                    inTriger = false;
                    PlayerPrefs.SetInt(item.itemName, 2);
                }
            }
        }
    }
    void Update()
    {
        Use();
    }
}
