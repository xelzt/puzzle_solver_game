using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPickDoorContoller : MonoBehaviour
{
    public GameObject doors;
    private bool animReady = true;
    void Start()
    {
        PlayerPrefs.SetInt("DidLockPickQuest", 0);
        PlayerPrefs.Save();
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("DidLockPickQuest") == 1 && animReady == true)
        {
            Debug.Log(PlayerPrefs.GetInt("DidLockPickQuest"));
            doors.GetComponent<Animation>().Play("LP_doors_open");
            animReady = false;
        }
    }
}
