using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room6FlyingBox : MonoBehaviour
{
    public GameObject FlyingBox;
    public GameObject WallButton;
    public GameObject AnimeObject;
    public bool Action;

    void Start()
    {
       // Instruction.SetActive(false);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        // Instruction.SetActive(false);
        Action = false;
    }

    void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action==true)
            {
                WallButton.GetComponent<Animation>().Play("Room6WallButton");
                AnimeObject.GetComponent<Animation>().Play("ButtonPushUp");
                    if (Room6Script.Action2)
                    {
                        FlyingBox.GetComponent<Animation>().Play("R6FlyingBox");
                    }
            }
        }
    }
}