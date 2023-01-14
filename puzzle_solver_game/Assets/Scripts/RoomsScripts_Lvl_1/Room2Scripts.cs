using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2Scripts : Room1Script
{ 
    public GameObject MovablePlatform;

    void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.200f, 0f);
        Doors.GetComponent<Animation> ().Play ("DoorsOpen");
        MovablePlatform.GetComponent<Animation> ().Play ("MovablePlatformOn_Room2");
    }
    
    void OnTriggerExit () {
        Button.transform.position += new Vector3(0f, 0.200f, 0f);
        Doors.GetComponent<Animation> ().Play ("DoorsClose");
        MovablePlatform.GetComponent<Animation> ().Play ("MovablePlatformOff_Room2");
    }
}