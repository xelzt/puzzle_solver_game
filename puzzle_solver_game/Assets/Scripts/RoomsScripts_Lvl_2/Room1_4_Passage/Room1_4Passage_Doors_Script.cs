using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1_4Passage_Doors_Script : MonoBehaviour
{
    [SerializeField]
    GameObject bulb1;
    [SerializeField]
    GameObject bulb2;

    public GameObject LeftDoors;
    public GameObject RightDoors;
    bool Bool = true;

    void Update()
    {
        if(Room2Lamp1.R2L1IsGreen==true &&
        Room2Lamp2.R2L2IsGreen==true &&
        Room2Lamp3.R2L3IsGreen==true &&
        Room2Lamp4.R2L4IsGreen==true &&
        Room2Lamp5.R2L5IsGreen==true &&
        Room3Lamp1.R3L1IsGreen==true &&
        Room3Lamp2.R3L2IsGreen==true &&
        Room3Lamp3.R3L3IsGreen==true &&
        Room3Lamp4.R3L4IsGreen==true &&
        Room3Lamp5.R3L5IsGreen==true &&
        Bool==true){
             LeftDoors.GetComponent<Animation>().Play("R1R4PLeftDoors2Open"); 
             RightDoors.GetComponent<Animation>().Play("R1R4PRightDoors2Open"); 
             Bool=false;
        } 

        if(Room2Lamp1.R2L1IsGreen==false ||
        Room2Lamp2.R2L2IsGreen==false ||
        Room2Lamp3.R2L3IsGreen==false ||
        Room2Lamp4.R2L4IsGreen==false ||
        Room2Lamp5.R2L5IsGreen==false ||
        Room3Lamp1.R3L1IsGreen==false ||
        Room3Lamp2.R3L2IsGreen==false ||
        Room3Lamp3.R3L3IsGreen==false ||
        Room3Lamp4.R3L4IsGreen==false ||
        Room3Lamp5.R3L5IsGreen==false ||
        Bool==true){
            if( Bool==false){
             LeftDoors.GetComponent<Animation>().Play("R1R4PLeftDoors2Close"); 
             RightDoors.GetComponent<Animation>().Play("R1R4PRightDoors2Close"); 
             Bool=true;}
        } 
  
        if(Room2Lamp1.R2L1IsGreen==true &&
        Room2Lamp2.R2L2IsGreen==true &&
        Room2Lamp3.R2L3IsGreen==true &&
        Room2Lamp4.R2L4IsGreen==true &&
        Room2Lamp5.R2L5IsGreen==true){
        bulb1.GetComponent<ColorChanger>().ChangeShardColour(Color.green);
        }

        if(Room3Lamp1.R3L1IsGreen==true &&
        Room3Lamp2.R3L2IsGreen==true &&
        Room3Lamp3.R3L3IsGreen==true &&
        Room3Lamp4.R3L4IsGreen==true &&
        Room3Lamp5.R3L5IsGreen==true){
        bulb2.GetComponent<ColorChanger>().ChangeShardColour(Color.green);
        }



    }
}
