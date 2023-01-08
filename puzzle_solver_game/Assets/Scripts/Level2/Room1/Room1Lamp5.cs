using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp5 : MonoBehaviour
{
    public bool Action;
    //public static bool L5IsRed = true;
    //public static bool L5IsBlue = false;
    public static bool L5IsGreen = false;
     public static bool L5IsRed = true;
    public static bool L5IsBlue = false;
    //public static bool L5IsGreen = true;
    public GameObject Light2;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
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

                if(Room1Lamp6.L6IsRed == true){Room1Lamp6.L6IsRed=false;Room1Lamp6.L6IsBlue=true;
                Light6.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp6.L6IsBlue == true){Room1Lamp6.L6IsBlue=false;Room1Lamp6.L6IsGreen=true;
                Light6.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp6.L6IsGreen=false;Room1Lamp6.L6IsRed=true;
                Light6.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(L5IsRed == true){L5IsRed=false;L5IsBlue=true;
                Light5.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L5IsBlue == true){L5IsBlue=false;L5IsGreen=true;
                Light5.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L5IsGreen=false;L5IsRed=true;
                Light5.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp8.L8IsRed == true){Room1Lamp8.L8IsRed=false;Room1Lamp8.L8IsBlue=true;
                Light8.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp8.L8IsBlue == true){Room1Lamp8.L8IsBlue=false;Room1Lamp8.L8IsGreen=true;
                Light8.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp8.L8IsGreen=false;Room1Lamp8.L8IsRed=true;
                Light8.GetComponent<Animation>().Play("LightChangeGreenRed");}

            }
        }
    }
}
