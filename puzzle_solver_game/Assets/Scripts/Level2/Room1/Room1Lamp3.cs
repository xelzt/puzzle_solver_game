using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp3 : MonoBehaviour
{
    public bool Action;
   // public static bool L3IsRed = true;
   // public static bool L3IsBlue = false;
    public static bool L3IsGreen = false;
    public static bool L3IsRed = true;
    public static bool L3IsBlue = false;
   // public static bool L3IsGreen = true;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light6;

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
                if(L3IsRed == true){L3IsRed=false;L3IsBlue=true;
                Light3.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L3IsBlue == true){L3IsBlue=false;L3IsGreen=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L3IsGreen=false;L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp2.L2IsRed == true){Room1Lamp2.L2IsRed=false;Room1Lamp2.L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp2.L2IsBlue == true){Room1Lamp2.L2IsBlue=false;Room1Lamp2.L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp2.L2IsGreen=false;Room1Lamp2.L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp6.L6IsRed == true){Room1Lamp6.L6IsRed=false;Room1Lamp6.L6IsBlue=true;
                Light6.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp6.L6IsBlue == true){Room1Lamp6.L6IsBlue=false;Room1Lamp6.L6IsGreen=true;
                Light6.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp6.L6IsGreen=false;Room1Lamp6.L6IsRed=true;
                Light6.GetComponent<Animation>().Play("LightChangeGreenRed");}

            }
        }
    }
}
