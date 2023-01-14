using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveElement : MonoBehaviour
{
    [SerializeField]
    public GameObject gameObj;// Object to active/hide
    public GameObject gameObj2;// Object to active/hide
    public GameObject gameObj3;// Object to active/hide
    private bool checkCondition = true;

    void Update()
    {
        if (PlayerPrefs.GetInt("DidElexQuest") == 1 && checkCondition)
        {
            gameObj.SetActive(false);
            gameObj2.SetActive(false);
            gameObj3.GetComponent<Collider>().enabled = true;
            checkCondition = false;
        }
    }
}
