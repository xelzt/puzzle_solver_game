using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp4 : MonoBehaviour
{
    public bool Action;
    public static bool LampBool4 = false;

    public GameObject Light1;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light7;

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
                if(LampBool4==false){LampBool4=true;
                Light4.GetComponent<Animation>().Play("LightChange");
                }else{LampBool4=false;
                Light4.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp1.LampBool1==false){Lamp1.LampBool1=true;
                Light1.GetComponent<Animation>().Play("LightChange");
                }else{Lamp1.LampBool1=false;
                Light1.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp5.LampBool5==false){Lamp5.LampBool5=true;
                Light5.GetComponent<Animation>().Play("LightChange");
                }else{Lamp5.LampBool5=false;
                Light5.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp7.LampBool7==false){Lamp7.LampBool7=true;
                Light7.GetComponent<Animation>().Play("LightChange");
                }else{Lamp7.LampBool7=false;
                Light7.GetComponent<Animation>().Play("LightChangeBack");}

            }
        }
    }
}
