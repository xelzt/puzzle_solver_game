using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp4 : MonoBehaviour
{
    public bool Action;
    //public static bool L4IsRed = true;
   // public static bool L4IsBlue = false;
    public static bool L4IsGreen = false;
    public static bool L4IsRed = true;
    public static bool L4IsBlue = false;
    //public static bool L4IsGreen = true;
    public GameObject Light1;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light7;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Action = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        Action = false;
    }
   
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action==true)
            {
                if(Room1Lamp1.L1IsRed == true){Room1Lamp1.L1IsRed=false;Room1Lamp1.L1IsBlue=true;
                Light1.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp1.L1IsBlue == true){Room1Lamp1.L1IsBlue=false;Room1Lamp1.L1IsGreen=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp1.L1IsGreen=false;Room1Lamp1.L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(L4IsRed == true){L4IsRed=false;L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L4IsBlue == true){L4IsBlue=false;L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L4IsGreen=false;L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp7.L7IsRed == true){Room1Lamp7.L7IsRed=false;Room1Lamp7.L7IsBlue=true;
                Light7.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp7.L7IsBlue == true){Room1Lamp7.L7IsBlue=false;Room1Lamp7.L7IsGreen=true;
                Light7.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp7.L7IsGreen=false;Room1Lamp7.L7IsRed=true;
                Light7.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp5.L5IsRed == true){Room1Lamp5.L5IsRed=false;Room1Lamp5.L5IsBlue=true;
                Light5.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp5.L5IsBlue == true){Room1Lamp5.L5IsBlue=false;Room1Lamp5.L5IsGreen=true;
                Light5.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp5.L5IsGreen=false;Room1Lamp5.L5IsRed=true;
                Light5.GetComponent<Animation>().Play("LightChangeGreenRed");}

            }
        }
    }
}
