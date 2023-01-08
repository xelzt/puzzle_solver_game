using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror4 : MonoBehaviour
{
    bool Action;
    bool M4 = false;
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
               Mir4.GetComponent<Animation> ().Play ("Mirror90");}
            }
        }
    }

