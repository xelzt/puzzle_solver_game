using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Script : MonoBehaviour
{
    public GameObject Button;
    public GameObject Doors;
    private bool alreadyPlayed = false;

    void OnTriggerEnter () {
        
        if(alreadyPlayed==false){
        Button.transform.position += new Vector3(0f, -0.200f, 0f);
        Doors.GetComponent<Animation> ().Play ("DoorsOpen");
        alreadyPlayed=true;}
    }
    
    void OnTriggerExit () {
        if(alreadyPlayed==true){
        Button.transform.position += new Vector3(0f, 0.200f, 0f);
        Doors.GetComponent<Animation> ().Play ("DoorsClose");
        alreadyPlayed=false;}
    }
}
