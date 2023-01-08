using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1RedDoorsScript : MonoBehaviour
{
    public GameObject LeftDoors;
    public GameObject RightDoors;
    bool Bool = true;
    bool Bool2 = true;

    void Update()
    {
        if(Room1Lamp1.L1IsRed==true &&
        Room1Lamp2.L2IsRed==true &&
        Room1Lamp3.L3IsRed==true &&
        Room1Lamp4.L4IsRed==true &&
        Room1Lamp5.L5IsRed==true &&
        Room1Lamp6.L6IsRed==true &&
        Room1Lamp7.L7IsRed==true &&
        Room1Lamp8.L8IsRed==true &&
        Room1Lamp9.L9IsRed==true &&
        Bool==true){
             LeftDoors.GetComponent<Animation>().Play("R1R4PLeftDoors1Open"); 
             RightDoors.GetComponent<Animation>().Play("R1R4PRightDoors1Open"); 
             Bool=false;
        } 

        if(Room1Lamp1.L1IsRed==false ||
        Room1Lamp2.L2IsRed==false ||
        Room1Lamp3.L3IsRed==false ||
        Room1Lamp4.L4IsRed==false ||
        Room1Lamp5.L5IsRed==false ||
        Room1Lamp6.L6IsRed==false ||
        Room1Lamp7.L7IsRed==false ||
        Room1Lamp8.L8IsRed==false ||
        Room1Lamp9.L9IsRed==false  ){
            if( Bool==false){
             LeftDoors.GetComponent<Animation>().Play("R1R4PLeftDoors1Close"); 
             RightDoors.GetComponent<Animation>().Play("R1R4PRightDoors1Close"); 
             Bool=true;}
        } 



    }
}
