using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp6 : MonoBehaviour
{
    public bool Action;
    public static bool L6IsRed = true;
    public static bool L6IsBlue = false;
    public static bool L6IsGreen = false;
    public GameObject Light3;
    public GameObject Light5;
    public GameObject Light6;
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
                if(L6IsRed == true){L6IsRed=false;L6IsBlue=true;
                Light6.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L6IsBlue == true){L6IsBlue=false;L6IsGreen=true;
                Light6.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L6IsGreen=false;L6IsRed=true;
                Light6.GetComponent<Animation>().Play("LightChangeGreenRed");}

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

                if(Room1Lamp9.L9IsRed == true){Room1Lamp9.L9IsRed=false;Room1Lamp9.L9IsBlue=true;
                Light9.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room1Lamp9.L9IsBlue == true){Room1Lamp9.L9IsBlue=false;Room1Lamp9.L9IsGreen=true;
                Light9.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room1Lamp9.L9IsGreen=false;Room1Lamp9.L9IsRed=true;
                Light9.GetComponent<Animation>().Play("LightChangeGreenRed");}

            }
        }
    }
}
