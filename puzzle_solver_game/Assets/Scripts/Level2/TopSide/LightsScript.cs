using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsScript : MonoBehaviour
{
    public GameObject Light;
    public bool Action;

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
               
            if(Mirror7.M7==true && Mirror6.M6==true && Mirror5.M5==true && Mirror4.M4==true && Mirror3.M3==true && Mirror2.M2==true && Mirror1.M1==true){
                Light.GetComponent<Animation>().Play("Light8Full");}else 
            if(Mirror6.M6==true && Mirror5.M5==true && Mirror4.M4==true && Mirror3.M3==true && Mirror2.M2==true && Mirror1.M1==true){
                Light.GetComponent<Animation>().Play("Light7F");}else 
            if(Mirror5.M5==true && Mirror4.M4==true && Mirror3.M3==true && Mirror2.M2==true && Mirror1.M1==true){
                Light.GetComponent<Animation>().Play("Light6F");}else 
            if(Mirror4.M4==true && Mirror3.M3==true && Mirror2.M2==true && Mirror1.M1==true){
                Light.GetComponent<Animation>().Play("Light5F");}else 
            if(Mirror3.M3==true && Mirror2.M2==true && Mirror1.M1==true){
                Light.GetComponent<Animation>().Play("Light4F");}else 
            if(Mirror2.M2==true && Mirror1.M1==true){
                Light.GetComponent<Animation>().Play("Light3F");}else 
            if(Mirror1.M1==true){
                Light.GetComponent<Animation>().Play("Light2F");}else {
                Light.GetComponent<Animation>().Play("Light1F");
            

        
        }}}}
}