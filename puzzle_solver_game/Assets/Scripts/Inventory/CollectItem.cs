using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public bool inTriger = false;
    public Item item;
    public GameObject gameObj;
    public Collider gameObjCollider;
    public Renderer gameObjRenderer;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            inTriger = true;
        }
    }
    void Collect()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTriger && gameObjRenderer.enabled)
        {
            Inventory.Instance.AddItem(item);
            Debug.Log("Collected: " + item);
            if (item.itemName == "PowerCell")
            {
                gameObjRenderer.enabled = false;
                gameObjCollider.enabled = false;
            }
            if (item.itemName == "skeletonKey" || item.itemName == "codeHint")
            {
                gameObjCollider.enabled = false;
            }

            inTriger = false;
        }
    }
    void Start()
    {
        gameObjCollider = GetComponent<Collider>();
        gameObjRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        Collect();
    }
}
