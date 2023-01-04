using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Lamp3 : MonoBehaviour
{
    public bool Action;
    public static bool R3L3IsRed = true;
    public static bool R3L3IsBlue = false;
    public static bool R3L3IsGreen = false;
    public GameObject Light2;
    public GameObject Light3;
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
         {if (Action==true)
            {
                if(R3L3IsRed == true){R3L3IsRed=false;R3L3IsBlue=true;
                Light3.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(R3L3IsBlue == true){R3L3IsBlue=false;R3L3IsGreen=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{R3L3IsGreen=false;R3L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room3Lamp2.R3L2IsRed == true){Room3Lamp2.R3L2IsRed=false;Room3Lamp2.R3L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room3Lamp2.R3L2IsBlue == true){Room3Lamp2.R3L2IsBlue=false;Room3Lamp2.R3L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room3Lamp2.R3L2IsGreen=false;Room3Lamp2.R3L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room3Lamp4.R3L4IsRed == true){Room3Lamp4.R3L4IsRed=false;Room3Lamp4.R3L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room3Lamp4.R3L4IsBlue == true){Room3Lamp4.R3L4IsBlue=false;Room3Lamp4.R3L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room3Lamp4.R3L4IsGreen=false;Room3Lamp4.R3L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }
    }
    }
}
