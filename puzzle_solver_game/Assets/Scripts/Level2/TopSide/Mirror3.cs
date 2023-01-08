using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror3 : MonoBehaviour
{
    bool Action;
    bool M3 = false;
    public GameObject Mir3;

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
               if(M3==true){M3=false;} else M3=true;
               Mir3.GetComponent<Animation> ().Play ("Mirror90");}
            }
        }
    }

