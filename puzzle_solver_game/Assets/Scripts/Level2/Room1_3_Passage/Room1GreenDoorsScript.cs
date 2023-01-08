using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1GreenDoorsScript : MonoBehaviour
{
    public GameObject LeftDoors;
    public GameObject RightDoors;
    bool Bool = true;

    void Update()
    {
        if(Room1Lamp1.L1IsGreen==true &&
        Room1Lamp2.L2IsGreen==true &&
        Room1Lamp3.L3IsGreen==true &&
        Room1Lamp4.L4IsGreen==true &&
        Room1Lamp5.L5IsGreen==true &&
        Room1Lamp6.L6IsGreen==true &&
        Room1Lamp7.L7IsGreen==true &&
        Room1Lamp8.L8IsGreen==true &&
        Room1Lamp9.L9IsGreen==true &&
        Bool==true){
             LeftDoors.GetComponent<Animation>().Play("R1R3PLeftDoors1Open"); 
             RightDoors.GetComponent<Animation>().Play("R1R3PRightDoors1Open"); 
             Bool=false;
        } 

        if(Room1Lamp1.L1IsGreen==false ||
        Room1Lamp2.L2IsGreen==false ||
        Room1Lamp3.L3IsGreen==false ||
        Room1Lamp4.L4IsGreen==false ||
        Room1Lamp5.L5IsGreen==false ||
        Room1Lamp6.L6IsGreen==false ||
        Room1Lamp7.L7IsGreen==false ||
        Room1Lamp8.L8IsGreen==false ||
        Room1Lamp9.L9IsGreen==false  ){
            if( Bool==false){
             LeftDoors.GetComponent<Animation>().Play("R1R3PLeftDoors1Close"); 
             RightDoors.GetComponent<Animation>().Play("R1R3PRightDoors1Close"); 
             Bool=true;}
        } 



    }
}
