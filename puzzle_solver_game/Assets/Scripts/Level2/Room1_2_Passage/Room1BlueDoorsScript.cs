using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1BlueDoorsScript : MonoBehaviour
{
    public GameObject LeftDoors;
    public GameObject RightDoors;
    bool Bool = true;

    void Update()
    {
        if(Room1Lamp1.L1IsBlue==true &&
        Room1Lamp2.L2IsBlue==true &&
        Room1Lamp3.L3IsBlue==true &&
        Room1Lamp4.L4IsBlue==true &&
        Room1Lamp5.L5IsBlue==true &&
        Room1Lamp6.L6IsBlue==true &&
        Room1Lamp7.L7IsBlue==true &&
        Room1Lamp8.L8IsBlue==true &&
        Room1Lamp9.L9IsBlue==true &&
        Bool==true){
             LeftDoors.GetComponent<Animation>().Play("R1R2PLeftDoors1Open"); 
             RightDoors.GetComponent<Animation>().Play("R1R2PRightDoors1Open"); 
             Bool=false;
        } 

        if(Room1Lamp1.L1IsBlue==false ||
        Room1Lamp2.L2IsBlue==false ||
        Room1Lamp3.L3IsBlue==false ||
        Room1Lamp4.L4IsBlue==false ||
        Room1Lamp5.L5IsBlue==false ||
        Room1Lamp6.L6IsBlue==false ||
        Room1Lamp7.L7IsBlue==false ||
        Room1Lamp8.L8IsBlue==false ||
        Room1Lamp9.L9IsBlue==false  ){
            if( Bool==false){
             LeftDoors.GetComponent<Animation>().Play("R1R2PLeftDoors1Close"); 
             RightDoors.GetComponent<Animation>().Play("R1R2PRightDoors1Close"); 
             Bool=true;}
        } 



    }
}
