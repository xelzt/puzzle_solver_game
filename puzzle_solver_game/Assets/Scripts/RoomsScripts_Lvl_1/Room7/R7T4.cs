using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R7T4 : MonoBehaviour
{
    public GameObject Button;
    public static bool Trig4 = false;
    void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.140f, 0f);
        for (int i = 0; i < 4; i++){
            if(Room7Script.Array[i]==0){
                Room7Script.Array[i]=4;
                 Trig4 = true;
                for (int j = 0; j < 4; j++){
                    if(Room7Script.Array[j]==4 && i!=j){
                         Room7Script.Array[j]=0;
                    }
                }
            break;
            }
        
    } 

    }

      void OnTriggerExit () {
       Button.transform.position += new Vector3(0f, 0.140f, 0f);
       Trig4 = false;
        { for (int i = 0; i < 4; i++){
        if(Room7Script.Array[i]==4){Room7Script.Array[i]=0;}
    }}
   }
}