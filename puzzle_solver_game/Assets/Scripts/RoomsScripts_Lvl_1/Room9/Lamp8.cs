using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp8 : MonoBehaviour
{
    public bool Action;
    public static bool LampBool8 = false;

    public GameObject Light5;
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
                if(LampBool8==false){LampBool8=true;
                Light8.GetComponent<Animation>().Play("LightChange");
                }else{LampBool8=false;
                Light8.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp7.LampBool7==false){Lamp7.LampBool7=true;
                Light7.GetComponent<Animation>().Play("LightChange");
                }else{Lamp7.LampBool7=false;
                Light7.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp9.LampBool9==false){Lamp9.LampBool9=true;
                Light9.GetComponent<Animation>().Play("LightChange");
                }else{Lamp9.LampBool9=false;
                Light9.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp5.LampBool5==false){Lamp5.LampBool5=true;
                Light5.GetComponent<Animation>().Play("LightChange");
                }else{Lamp5.LampBool5=false;
                Light5.GetComponent<Animation>().Play("LightChangeBack");}

            }
        }
    }
}
