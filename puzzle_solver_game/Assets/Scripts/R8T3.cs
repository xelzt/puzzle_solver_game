using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R8T3 : MonoBehaviour
{
    public GameObject Button;
    public static bool Trig3 = false;

        void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.140f, 0f);
        Trig3 = true;
    } 

        void OnTriggerExit () { 
        Button.transform.position += new Vector3(0f, 0.140f, 0f);
        Trig3 = false;
    }

}  