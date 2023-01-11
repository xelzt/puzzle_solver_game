using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public bool inTriger = false;
    public Item item;
    public GameObject gameObj;// Object to active/hide
    public Collider gameObjCollider;// Object to active/hide
    public Renderer gameObjRenderer;// Object to active/hide

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
        if (gameObj.name == "Nexus" | gameObj.name == "Nexus_to_input")
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
