using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public bool inTriger = false;
    public Item item;
    public GameObject gameObj;// Object to active/hide
    public Collider gameObjCollider;// Object to active/hide
    public Renderer gameObjRenderer;// Object to active/hide

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
        if (Input.GetKeyDown(KeyCode.R) && inTriger && !gameObjRenderer.enabled)
        {
            for (int i = 0; i < Inventory.Instance.itemList.Count; i++)
            {
                if (Inventory.Instance.itemList[i].itemName == item.itemName)
                {
                    Inventory.Instance.RemoveItem(item);
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
