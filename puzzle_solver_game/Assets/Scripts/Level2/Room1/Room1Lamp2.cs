using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp2 : MonoBehaviour
{
    public bool Action;
    public static bool L2IsGreen = false;
    public static bool L2IsRed = true;
    public static bool L2IsBlue = false;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light5;

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

                if(L2IsRed == true){L2IsRed=false;L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L2IsBlue == true){L2IsBlue=false;L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L2IsGreen=false;L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp3.L3IsRed == true){Room1Lamp3.L3IsRed=false;Room1Lamp3.L3IsBlue=true;
                Light3.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp3.L3IsBlue == true){Room1Lamp3.L3IsBlue=false;Room1Lamp3.L3IsGreen=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp3.L3IsGreen=false;Room1Lamp3.L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}

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
