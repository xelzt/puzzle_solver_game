using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror4 : MonoBehaviour
{
    bool Action;
    public static bool M4 = true;
    public GameObject Mir4;

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
               if(M4==true){M4=false;} else M4=true;
               Mir4.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);}
            }
        }
    }

