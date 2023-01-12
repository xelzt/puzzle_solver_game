using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveElement : MonoBehaviour
{
    [SerializeField]
    public GameObject gameObj;// Object to active/hide

    void Update()
    {
        if (PlayerPrefs.GetInt("DidElexQuest") == 1)
        {
            gameObj.SetActive(false);
        }
    }
}
