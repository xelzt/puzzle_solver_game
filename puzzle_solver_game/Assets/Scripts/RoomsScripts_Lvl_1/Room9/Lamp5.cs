using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp5 : MonoBehaviour
{
    public bool Action;
    public static bool LampBool5 = false;

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
                if(LampBool5==false){LampBool5=true;
                Light5.GetComponent<Animation>().Play("LightChange");
                }else{LampBool5=false;
                Light5.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp2.LampBool2==false){Lamp2.LampBool2=true;
                Light2.GetComponent<Animation>().Play("LightChange");
                }else{Lamp2.LampBool2=false;
                Light2.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp4.LampBool4==false){Lamp4.LampBool4=true;
                Light4.GetComponent<Animation>().Play("LightChange");
                }else{Lamp4.LampBool4=false;
                Light4.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp6.LampBool6==false){Lamp6.LampBool6=true;
                Light6.GetComponent<Animation>().Play("LightChange");
                }else{Lamp6.LampBool6=false;
                Light6.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp8.LampBool8==false){Lamp8.LampBool8=true;
                Light8.GetComponent<Animation>().Play("LightChange");
                }else{Lamp8.LampBool8=false;
                Light8.GetComponent<Animation>().Play("LightChangeBack");}

            }
        }
    }
}