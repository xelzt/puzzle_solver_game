using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror6 : MonoBehaviour
{
    bool Action;
    public static bool M6 = true;
    public GameObject Mir6;

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
               if(M6==true){M6=false;} else M6=true;
               Mir6.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);}
            }
        }
    }

