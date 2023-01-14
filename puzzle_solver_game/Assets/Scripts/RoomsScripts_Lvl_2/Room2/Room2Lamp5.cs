using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2Lamp5 : MonoBehaviour
{
    public bool Action;
    public static bool R2L5IsRed = true;
    public static bool R2L5IsBlue = false;
    public static bool R2L5IsGreen = false;
    public GameObject Light4;
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
        {if (Action==true)
            {
                if(R2L5IsRed == true){R2L5IsRed=false;R2L5IsBlue=true;
                Light5.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(R2L5IsBlue == true){R2L5IsBlue=false;R2L5IsGreen=true;
                Light5.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{R2L5IsGreen=false;R2L5IsRed=true;
                Light5.GetComponent<Animation>().Play("LightChangeGreenRed");}

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
