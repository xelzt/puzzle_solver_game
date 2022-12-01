using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room6Script : MonoBehaviour

{
    string string1 = "FlyingBox2";
    public static bool Action2 = false;
      public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == string1)
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
