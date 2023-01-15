using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public Item item;
    public bool inTriger = false;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            inTriger = true;
        }
    }

    public void Collect()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTriger)
        {
            InventoryManager.Instance.AddItem(item);
            PlayerPrefs.SetInt(item.itemName, 1);
            Destroy(gameObject, 0.1f);

            inTriger = false;
        }
    }
    private void Update()
    {
        Collect();
    }
}
