using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Trig3 : MonoBehaviour
{
    public GameObject Button;
    public GameObject Doors;
    public static bool Trig3 = false;

    void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.240f, 0f);
        Doors.GetComponent<Animation> ().Play ("DoorsOpen");
        Trig3 = true;
    }
    
    void OnTriggerExit () {
        Button.transform.position += new Vector3(0f, 0.240f, 0f);
        Doors.GetComponent<Animation> ().Play ("DoorsClose");
        Trig3 = false;
    }
}
