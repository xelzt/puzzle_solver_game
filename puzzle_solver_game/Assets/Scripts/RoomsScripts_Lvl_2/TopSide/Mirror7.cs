using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror7 : MonoBehaviour
{
    public static bool Bloced =true;
    bool Action;
    public static bool M7 = true;
    public GameObject Mir7;

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
                if(Bloced==true){
               if(M7==true){M7=false;} else M7=true;
               Mir7.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);}}
            }
        }
    }

