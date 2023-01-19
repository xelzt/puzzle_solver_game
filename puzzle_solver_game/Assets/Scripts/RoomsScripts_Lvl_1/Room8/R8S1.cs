using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R8S1 : MonoBehaviour
{
    public GameObject Box3;
    public GameObject Box2;
    public GameObject Box1;
    public GameObject Doors;
    public GameObject Platform2;
    public GameObject Platform1;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject ButtonWall;
    bool Action;
    bool b1 = true;
    bool b2 = true;
    bool b3 = true;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Instruction.SetActive(true);
            Action = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        // Instruction.SetActive(false);
        Action = false;
    }


     void Update()
    {
        if(R8T2.Trig2 == true && b1 == true){Platform1.GetComponent<Animation> ().Play ("Platform1Anim");b1= false;}
        if(R8T2.Trig2 == false && b1 == false){Platform1.GetComponent<Animation> ().Play ("Platform1Anim2");b1= true;} 

        if(R8T1.Trig1 == true && b2 == true){Platform2.GetComponent<Animation> ().Play ("Platform2Anim");b2= false;}
        if(R8T1.Trig1 == false && b2 == false){Platform2.GetComponent<Animation> ().Play ("Platform2Anim2");b2= true;}

        if(R8T4.Trig4 == true && R8T5.Trig5 == true && b3 == true){Doors.GetComponent<Animation> ().Play ("DoorsOpen");b3= false;}
        if(R8T4.Trig4 == true && R8T5.Trig5 == true && b3 == false){Doors.GetComponent<Animation> ().Play ("DoorsClose");b3= true;}
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action==true)
            {
                ButtonWall.GetComponent<Animation> ().Play ("WallButtonR8"); 
                Button1.GetComponent<Animation> ().Play ("GreenFButt"); 
                Button2.GetComponent<Animation> ().Play ("BlueFButt"); 
                if(R8T3.Trig3 == true)Box3.GetComponent<Animation> ().Play ("R8BoxUp");
                if(R8T2.Trig2 == true)Box2.GetComponent<Animation> ().Play ("R8Box2");
                if(R8T1.Trig1 == true)Box1.GetComponent<Animation> ().Play ("R8Box1");
            }
        }
    }
}
 
    