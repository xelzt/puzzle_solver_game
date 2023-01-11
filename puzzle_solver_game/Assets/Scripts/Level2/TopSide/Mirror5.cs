using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror5 : MonoBehaviour
{
    bool Action;
    public static bool M5 = true;
    public GameObject Mir5;

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
               if(M5==true){M5=false;} else M5=true;
               Mir5.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);}
            }
        }
    }

