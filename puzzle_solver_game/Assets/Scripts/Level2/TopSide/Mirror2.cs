using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror2 : MonoBehaviour
{
    bool Action;
    public static bool M2 = false;
    public GameObject Mir2;

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
               if(M2==true){M2=false;} else M2=true;
               Mir2.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            }
        }
    }

}