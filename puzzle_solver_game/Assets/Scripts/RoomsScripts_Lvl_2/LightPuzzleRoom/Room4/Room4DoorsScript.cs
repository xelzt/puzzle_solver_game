using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4DoorsScript : MonoBehaviour
{
    public GameObject LeftDoors;
    public GameObject RightDoors;
    public GameObject LeftDoors2;
    public GameObject RightDoors2;
    bool Bool = true;
    bool Bool2 = true;

    void Update()
    {
        if(Room4Lamp1.L1IsGreen==true &&
        Room4Lamp2.L2IsGreen==true &&
        Room4Lamp3.L3IsGreen==true &&
        Room4Lamp4.L4IsGreen==true &&
        Room4Lamp5.L5IsGreen==true &&
        Room4Lamp6.L6IsGreen==true &&
        Room4Lamp7.L7IsGreen==true &&
        Room4Lamp8.L8IsGreen==true &&
        Room4Lamp9.L9IsGreen==true &&
        Room4Lamp10.L10IsGreen==true &&
        Bool==true){
             LeftDoors.GetComponent<Animation>().Play("R4LeftDoors1Open"); 
             RightDoors.GetComponent<Animation>().Play("R4RightDoors1Open"); 
             Bool=false;
        } 
         if(Room4Lamp1.L1IsBlue==true &&
        Room4Lamp2.L2IsBlue==true &&
        Room4Lamp3.L3IsBlue==true &&
        Room4Lamp4.L4IsBlue==true &&
        Room4Lamp5.L5IsBlue==true &&
        Room4Lamp6.L6IsBlue==true &&
        Room4Lamp7.L7IsBlue==true &&
        Room4Lamp8.L8IsBlue==true &&
        Room4Lamp9.L9IsBlue==true &&
        Room4Lamp10.L10IsBlue==true &&
        Bool2==true){
             LeftDoors2.GetComponent<Animation>().Play("R4LeftDoors2Open"); 
             RightDoors2.GetComponent<Animation>().Play("R4RightDoors2Open"); 
             Bool2=false;
        } 



        if(Room4Lamp1.L1IsGreen==false ||
        Room4Lamp2.L2IsGreen==false ||
        Room4Lamp3.L3IsGreen==false ||
        Room4Lamp4.L4IsGreen==false ||
        Room4Lamp5.L5IsGreen==false ||
        Room4Lamp6.L6IsGreen==false ||
        Room4Lamp7.L7IsGreen==false ||
        Room4Lamp8.L8IsGreen==false ||
        Room4Lamp9.L9IsGreen==false ||
        Room4Lamp10.L10IsGreen==false   ){
            if( Bool==false){
             LeftDoors.GetComponent<Animation>().Play("R4LeftDoors1Close"); 
             RightDoors.GetComponent<Animation>().Play("R4RightDoors1Close"); 
             Bool=true;}
        } 
        
        if(Room4Lamp1.L1IsBlue==false ||
        Room4Lamp2.L2IsBlue==false ||
        Room4Lamp3.L3IsBlue==false ||
        Room4Lamp4.L4IsBlue==false ||
        Room4Lamp5.L5IsBlue==false ||
        Room4Lamp6.L6IsBlue==false ||
        Room4Lamp7.L7IsBlue==false ||
        Room4Lamp8.L8IsBlue==false ||
        Room4Lamp9.L9IsBlue==false ||
          Room4Lamp10.L10IsGreen==false 
        ){
            if( Bool2==false){
             LeftDoors2.GetComponent<Animation>().Play("R4LeftDoors2Close"); 
             RightDoors2.GetComponent<Animation>().Play("R4RightDoors2Close"); 
             Bool2=true;}
        } 

    }
}
