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
        if (other.tag == "Player")
        {
            inTriger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
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
            for (int i = 0; i < InventoryManager.Instance.itemList.Count; i++)
            {
                if (InventoryManager.Instance.itemList[i].itemName == item.itemName)
                {
                    InventoryManager.Instance.RemoveItem(item);
                    gameObjCollider.enabled = true;
                    gameObjRenderer.enabled = true;
                    inTriger = false;
                }
            }
        }
    }
    void Update()
    {
        Use();
    }
}
