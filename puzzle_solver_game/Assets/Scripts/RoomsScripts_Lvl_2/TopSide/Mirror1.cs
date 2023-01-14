using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror1 : MonoBehaviour
{
    bool Action;
    public static bool M1 = false;
    public GameObject Mir1;

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
               if(M1==true){M1=false;} else M1=true;
               Mir1.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            }
        }
    }
}
