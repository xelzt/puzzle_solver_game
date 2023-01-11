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
            gameObjRenderer.enabled = false;
            gameObjCollider.enabled = false;
            inTriger = false;
        }
    }
    void Start()
    {
        if (gameObj.name == "Nexus")
        {
            gameObjCollider = GetComponent<Collider>();
            gameObjRenderer = GetComponent<Renderer>();
        }
    }

    void Update()
    {
        Collect();
    }
}
