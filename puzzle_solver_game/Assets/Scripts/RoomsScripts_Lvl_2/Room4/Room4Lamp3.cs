using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp3 : MonoBehaviour
{
    public bool Action;
    public static bool L3IsBlue = false;
    public static bool L3IsGreen = false;
    public static bool L3IsRed = true;
    public GameObject Light4;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light8;

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

                if(Room4Lamp2.L2IsRed == true){Room4Lamp2.L2IsRed=false;Room4Lamp2.L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp2.L2IsBlue == true){Room4Lamp2.L2IsBlue=false;Room4Lamp2.L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp2.L2IsGreen=false;Room4Lamp2.L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp4.L4IsRed == true){Room4Lamp4.L4IsRed=false;Room4Lamp4.L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp4.L4IsBlue == true){Room4Lamp4.L4IsBlue=false;Room4Lamp4.L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp4.L4IsGreen=false;Room4Lamp4.L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp8.L8IsRed == true){Room4Lamp8.L8IsRed=false;Room4Lamp8.L8IsBlue=true;
                Light8.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp8.L8IsBlue == true){Room4Lamp8.L8IsBlue=false;Room4Lamp8.L8IsGreen=true;
                Light8.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp8.L8IsGreen=false;Room4Lamp8.L8IsRed=true;
                Light8.GetComponent<Animation>().Play("LightChangeGreenRed");}
            }
        }
    }
}
