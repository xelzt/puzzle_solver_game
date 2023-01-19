using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room6ActiveButton : MonoBehaviour
{
    public bool Action;
    [SerializeField]
    GameObject shard_to_blink;
    [SerializeField]
    GameObject button_to_blink;

     void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Action = false;
    }

     void Update()
    {
    
       if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action==true)
            {
               shard_to_blink.GetComponent<ColorChanger>().ChangeShardColour(Color.green);
               button_to_blink.GetComponent<ColorChanger>().ChangeShardColour(Color.green);
                PlayerPrefs.SetInt("LampPortalButton", 1);
            }
        }
    }
}
