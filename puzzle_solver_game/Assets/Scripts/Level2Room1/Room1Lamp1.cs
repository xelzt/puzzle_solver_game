using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp1 : MonoBehaviour
{
    public bool Action;
    public static bool L1IsRed = true;
    public static bool L1IsBlue = false;
    public static bool L1IsGreen = false;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light4;

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
                if(L1IsRed == true){L1IsRed=false;L1IsBlue=true;
                Light1.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L1IsBlue == true){L1IsBlue=false;L1IsGreen=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L1IsGreen=false;L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp2.L2IsRed == true){Room1Lamp2.L2IsRed=false;Room1Lamp2.L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp2.L2IsBlue == true){Room1Lamp2.L2IsBlue=false;Room1Lamp2.L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp2.L2IsGreen=false;Room1Lamp2.L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp4.L4IsRed == true){Room1Lamp4.L4IsRed=false;Room1Lamp4.L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp4.L4IsBlue == true){Room1Lamp4.L4IsBlue=false;Room1Lamp4.L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp4.L4IsGreen=false;Room1Lamp4.L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}

            }
        }
    }
}
