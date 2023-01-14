using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp5 : MonoBehaviour
{
    public bool Action;
    public static bool L5IsBlue = false;
    public static bool L5IsGreen = false;
    public static bool L5IsRed = true;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light10;

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
                if(L5IsRed == true){L5IsRed=false;L5IsBlue=true;
                Light5.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L5IsBlue == true){L5IsBlue=false;L5IsGreen=true;
                Light5.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L5IsGreen=false;L5IsRed=true;
                Light5.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp4.L4IsRed == true){Room4Lamp4.L4IsRed=false;Room4Lamp4.L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp4.L4IsBlue == true){Room4Lamp4.L4IsBlue=false;Room4Lamp4.L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp4.L4IsGreen=false;Room4Lamp4.L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp10.L10IsRed == true){Room4Lamp10.L10IsRed=false;Room4Lamp10.L10IsBlue=true;
                Light10.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp10.L10IsBlue == true){Room4Lamp10.L10IsBlue=false;Room4Lamp10.L10IsGreen=true;
                Light10.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp10.L10IsGreen=false;Room4Lamp10.L10IsRed=true;
                Light10.GetComponent<Animation>().Play("LightChangeGreenRed");}

            }
        }
    }
}
