using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp6 : MonoBehaviour
{
    public bool Action;
    public static bool LampBool6 = false;

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
                if(LampBool6==false){LampBool6=true;
                Light6.GetComponent<Animation>().Play("LightChange");
                }else{LampBool6=false;
                Light6.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp3.LampBool3==false){Lamp3.LampBool3=true;
                Light3.GetComponent<Animation>().Play("LightChange");
                }else{Lamp3.LampBool3=false;
                Light3.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp5.LampBool5==false){Lamp5.LampBool5=true;
                Light5.GetComponent<Animation>().Play("LightChange");
                }else{Lamp5.LampBool5=false;
                Light5.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp9.LampBool9==false){Lamp9.LampBool9=true;
                Light9.GetComponent<Animation>().Play("LightChange");
                }else{Lamp9.LampBool9=false;
                Light9.GetComponent<Animation>().Play("LightChangeBack");}

            }
        }
    }
}
