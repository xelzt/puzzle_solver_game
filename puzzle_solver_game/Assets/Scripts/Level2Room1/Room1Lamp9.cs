using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp9 : MonoBehaviour
{
    public bool Action;
    public static bool L9IsRed = true;
    public static bool L9IsBlue = false;
    public static bool L9IsGreen = false;
    public GameObject Light6;
    public GameObject Light8;
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
                if(L9IsRed == true){L9IsRed=false;L9IsBlue=true;
                Light9.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L9IsBlue == true){L9IsBlue=false;L9IsGreen=true;
                Light9.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L9IsGreen=false;L9IsRed=true;
                Light9.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp8.L8IsRed == true){Room1Lamp8.L8IsRed=false;Room1Lamp8.L8IsBlue=true;
                Light8.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp8.L8IsBlue == true){Room1Lamp8.L8IsBlue=false;Room1Lamp8.L8IsGreen=true;
                Light8.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp8.L8IsGreen=false;Room1Lamp8.L8IsRed=true;
                Light8.GetComponent<Animation>().Play("LightChangeGreenRed");}

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
