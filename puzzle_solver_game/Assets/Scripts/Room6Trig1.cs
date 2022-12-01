using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room6Trig1 : MonoBehaviour
{
    public GameObject Bridge;
    public GameObject Button;
    bool Bool = false;

    void OnTriggerEnter () {
      Button.transform.position += new Vector3(0f, -0.200f, 0f);
      if(Bool==false){
        Bridge.GetComponent<Animation>().Play("BridgeMoveOn"); 
        Bool=true;
      }else{
         Bridge.GetComponent<Animation>().Play("BridgeMoveOff"); 
        Bool = false;
      }
    }
    void OnTriggerExit () {
       Button.transform.position += new Vector3(0f, 0.200f, 0f);
    }
 
}
