using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror7 : MonoBehaviour
{
    bool Action;
    bool M7 = false;
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
               if(M7==true){M7=false;} else M7=true;
               Mir7.GetComponent<Animation> ().Play ("Mirror90");}
            }
        }
    }

