using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R7T1 : MonoBehaviour
{
    public GameObject Button;
    public static bool Trig1 = false;
    void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.140f, 0f);
        for (int i = 0; i < 4; i++){
            if(Room7Script.Array[i]==0){
                Room7Script.Array[i]=1;
                 Trig1 = true;
                for (int j = 0; j < 4; j++){
                    if(Room7Script.Array[j]==1 && i!=j){
                         Room7Script.Array[j]=0;
                    }
                }
            break;
            }
        
    } 

    }
      void OnTriggerExit () {
       Button.transform.position += new Vector3(0f, 0.140f, 0f);
       Trig1 = false;
        { for (int i = 0; i < 4; i++){
        if(Room7Script.Array[i]==1){Room7Script.Array[i]=0;}
    }}
   }
}
