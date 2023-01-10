using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitDoorsContoller : MonoBehaviour
{
    public GameObject leftDoors;
    public GameObject rightDoors;
    bool animReady = true;
    void Update()
    {
        if(PlayerPrefs.GetInt("DidDigitQuest") ==1 && animReady == true)
        {
            leftDoors.GetComponent<Animation>().Play("CPR_left_doors_open");
            rightDoors.GetComponent<Animation>().Play("CPR_right_doors_open");
            animReady = false;
        }
    }
}
