using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp7 : MonoBehaviour
{
    public bool Action;
   // public static bool L7IsRed = true;
   // public static bool L7IsBlue = false;
   public static bool L7IsGreen = false;
        public static bool L7IsRed = true;
   public static bool L7IsBlue = false;
    //public static bool L7IsGreen = true;
    public GameObject Light4;
    public GameObject Light7;
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
                

                if(Room1Lamp4.L4IsRed == true){Room1Lamp4.L4IsRed=false;Room1Lamp4.L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp4.L4IsBlue == true){Room1Lamp4.L4IsBlue=false;Room1Lamp4.L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp4.L4IsGreen=false;Room1Lamp4.L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(L7IsRed == true){L7IsRed=false;L7IsBlue=true;
                Light7.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L7IsBlue == true){L7IsBlue=false;L7IsGreen=true;
                Light7.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L7IsGreen=false;L7IsRed=true;
                Light7.GetComponent<Animation>().Play("LightChangeGreenRed");}

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
