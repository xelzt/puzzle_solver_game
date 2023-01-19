using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R8T1 : MonoBehaviour
{
    public GameObject Button;
    public static bool Trig1 = false;

        void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.140f, 0f);
        Trig1 = true;
    } 

        void OnTriggerExit () { 
        Button.transform.position += new Vector3(0f, 0.140f, 0f);
        Trig1 = false;
    }


}  