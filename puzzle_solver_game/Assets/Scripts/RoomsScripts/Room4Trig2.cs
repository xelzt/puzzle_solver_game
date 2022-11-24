using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Trig2 : MonoBehaviour
{
    public GameObject Button;
    public static bool Trig2 = false;

    void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.240f, 0f);
        Trig2 = true;
    }
    
    void OnTriggerExit () {
        Button.transform.position += new Vector3(0f, 0.240f, 0f);
        Trig2 = false;
    }
}
