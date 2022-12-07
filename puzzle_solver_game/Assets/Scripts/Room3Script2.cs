using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Script2 : MonoBehaviour
{
    public GameObject Button;
    public GameObject Doors;

    void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.240f, 0f);
        Doors.GetComponent<Animation> ().Play ("DoorsOpen");
    }
    
    void OnTriggerExit () {
        Button.transform.position += new Vector3(0f, 0.240f, 0f);
        Doors.GetComponent<Animation> ().Play ("DoorsClose");
    }
}