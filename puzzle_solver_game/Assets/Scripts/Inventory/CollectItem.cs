using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    private bool inTriger = false;
    public Item item;

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
    void Collect()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTriger)
        {
            Inventory.Instance.AddItem(item);
            Debug.Log("Collected: " + item);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        Collect();
    }
}
