using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class Room7Script : MonoBehaviour
{
    public GameObject Doors;
    public GameObject Platform;
    public bool Solved;
    public static int[] Array = new int[]{0,0,0,0};
    //int[] Array = new int[]{0,0,0,0};
    public static int[] Array2 = new int[]{1,2,3,4};
    int o = 0;
    void Update()
{
    
     //Debug.Log(Array2[0]+" "+Array2[1]+" "+Array2[2]+" "+Array2[3]+" ");
    // Debug.Log("miejsca:"+ArrayPom[0]+" "+ArrayPom[1]+" "+ArrayPom[2]+" "+ArrayPom[3]+" ");
   // for (int i = 0; i < 4; i++)
           // {
                if(Array[0]==Array2[0]&&Array[1]==Array2[1]&&Array[2]==Array2[2]&&Array[3]==Array2[3]){Solved=true;}else {Solved=false;}
         //   }
    // Debug.Log(R7T1.Trig1);
    // Debug.Log(R7T2.Trig2);
    // Debug.Log(R7T3.Trig3);
    // Debug.Log(R7T4.Trig4);

    if(R7T1.Trig1 == true && R7T2.Trig2 == true && R7T3.Trig3 == true && R7T4.Trig4 == true){
        if (Solved == false){
            //Miejsce na animacje/przesunięcie boksów po złym ułożeniu
           
        }
    }
   
    if(Solved == true && o == 0){
    Platform.GetComponent<Animation> ().Play ("Room7Platform");
    Doors.GetComponent<Animation> ().Play ("DoorsOpen");
    o = 1;
    }else if(Solved == false && o == 1){
        Platform.GetComponent<Animation> ().Play ("Room7PlatformB");
        Doors.GetComponent<Animation> ().Play ("DoorsClose");
        o = 0; 
    }

  
  }
 
}
