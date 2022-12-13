using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp10 : MonoBehaviour
{
    public bool Action;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;
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

                if(Lamp1.LampBool1==true){Lamp1.LampBool1=false;
                Light1.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp2.LampBool2==true){Lamp2.LampBool2=false;
                Light2.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp3.LampBool3==true){Lamp3.LampBool3=false;
                Light3.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp4.LampBool4==true){Lamp4.LampBool4=false;
                Light4.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp5.LampBool5==true){Lamp5.LampBool5=false;
                Light5.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp6.LampBool6==true){Lamp6.LampBool6=false;
                Light6.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp7.LampBool7==true){Lamp7.LampBool7=false;
                Light7.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp8.LampBool8==true){Lamp8.LampBool8=false;
                Light8.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp9.LampBool9==true){Lamp9.LampBool9=false;
                Light9.GetComponent<Animation>().Play("LightChangeBack");}


            }
        }
    }
}
