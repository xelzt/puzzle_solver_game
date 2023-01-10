using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp4 : MonoBehaviour
{
    public bool Action;
    public static bool L4IsBlue = false;
    public static bool L4IsGreen = false;
    public static bool L4IsRed = true;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light3;
    public GameObject Light9;

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
                if(L4IsRed == true){L4IsRed=false;L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L4IsBlue == true){L4IsBlue=false;L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L4IsGreen=false;L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp3.L3IsRed == true){Room4Lamp3.L3IsRed=false;Room4Lamp3.L3IsBlue=true;
                Light3.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp3.L3IsBlue == true){Room4Lamp3.L3IsBlue=false;Room4Lamp3.L3IsGreen=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp3.L3IsGreen=false;Room4Lamp3.L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp5.L5IsRed == true){Room4Lamp5.L5IsRed=false;Room4Lamp5.L5IsBlue=true;
                Light5.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp5.L5IsBlue == true){Room4Lamp5.L5IsBlue=false;Room4Lamp5.L5IsGreen=true;
                Light5.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp5.L5IsGreen=false;Room4Lamp5.L5IsRed=true;
                Light5.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp9.L9IsRed == true){Room4Lamp9.L9IsRed=false;Room4Lamp9.L9IsBlue=true;
                Light9.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp9.L9IsBlue == true){Room4Lamp9.L9IsBlue=false;Room4Lamp9.L9IsGreen=true;
                Light9.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp9.L9IsGreen=false;Room4Lamp9.L9IsRed=true;
                Light9.GetComponent<Animation>().Play("LightChangeGreenRed");}
            }
        }
    }
}
