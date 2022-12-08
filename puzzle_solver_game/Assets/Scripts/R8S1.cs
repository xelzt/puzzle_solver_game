using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R8S1 : MonoBehaviour
{
    public GameObject Box3;
    public GameObject Platform2;
    public GameObject Platform1;
    
    public bool Action;

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


     void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action==true)
            {
               if(R8T3.Trig3 == true)Box3.GetComponent<Animation> ().Play ("R8BoxUp"); ;
               if(R8T2.Trig2 == true){Platform2.GetComponent<Animation> ().Play ("R8Platform");} else {Platform2.GetComponent<Animation> ().Play ("R8PlatformOff");};
               if(R8T1.Trig1 == true)Platform1.GetComponent<Animation> ().Play ("R8Platform2");else Platform2.GetComponent<Animation> ().Play ("R8Platform2Off") ;


            }
        }
    }
}
 
    