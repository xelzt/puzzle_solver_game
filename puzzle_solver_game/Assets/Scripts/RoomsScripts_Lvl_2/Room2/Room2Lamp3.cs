using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2Lamp3 : MonoBehaviour
{
    public bool Action;
    public static bool R2L3IsRed = true;
    public static bool R2L3IsBlue = false;
    public static bool R2L3IsGreen = false;
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
                if(R2L3IsRed == true){R2L3IsRed=false;R2L3IsBlue=true;
                Light3.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(R2L3IsBlue == true){R2L3IsBlue=false;R2L3IsGreen=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{R2L3IsGreen=false;R2L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room2Lamp2.R2L2IsRed == true){Room2Lamp2.R2L2IsRed=false;Room2Lamp2.R2L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room2Lamp2.R2L2IsBlue == true){Room2Lamp2.R2L2IsBlue=false;Room2Lamp2.R2L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room2Lamp2.R2L2IsGreen=false;Room2Lamp2.R2L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room2Lamp4.R2L4IsRed == true){Room2Lamp4.R2L4IsRed=false;Room2Lamp4.R2L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room2Lamp4.R2L4IsBlue == true){Room2Lamp4.R2L4IsBlue=false;Room2Lamp4.R2L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room2Lamp4.R2L4IsGreen=false;Room2Lamp4.R2L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }
    }
    }
}
