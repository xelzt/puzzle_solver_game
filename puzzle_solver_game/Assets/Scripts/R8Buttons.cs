using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R8Buttons : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Box;
     public GameObject Box2;
    public bool Action;

    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action==true)
            {
                Button1.GetComponent<Animation>().Play("R8Button1");
                Button2.GetComponent<Animation>().Play("R8Button2");
                Button3.GetComponent<Animation>().Play("R8Button3");
                Box.GetComponent<Animation>().Play("test1");
                    Box2.GetComponent<Animation>().Play("test1");
                  //  if (Flying.Action2)
                  //  {
                     //   FlyingBox.GetComponent<Animation>().Play("Room3BoxAnim");
                  //  }
            }
        }
    }
}
