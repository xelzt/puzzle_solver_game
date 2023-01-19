using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flying : MonoBehaviour

{
public static bool Action2 = false;
      public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "FlyingBox")
        {
         Action2 = true;
        }
    }
     void OnTriggerExit(Collider collision)
    {
       // Instruction.SetActive(false);
        Action2 = false;
    }

}
