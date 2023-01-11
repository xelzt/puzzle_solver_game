using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger : MonoBehaviour
{
    [SerializeField]
    public GameObject canvasPanel;// Object to active
    private bool inTriger = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inTriger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inTriger = false;
        }
    }
    void enterPanel()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTriger)
        {
            if (canvasPanel.name == "LockSimonSays" && PlayerPrefs.GetInt("DidSimonSaysQuest") != 1)
            {
                canvasPanel.SetActive(true);
            }
            if (canvasPanel.name == "LockDigit" && PlayerPrefs.GetInt("DidDigitQuest") != 1)
            {
                canvasPanel.SetActive(true);
            }if (canvasPanel.name == "LockElex" && PlayerPrefs.GetInt("DidElexQuest") != 1)
            {
                canvasPanel.SetActive(true);
            }
            if (canvasPanel.name == "LockPick" && PlayerPrefs.GetInt("DidLockPickQuest") != 1)
            {
                canvasPanel.SetActive(true);
            }
        }
    }
    void Update()
    {
        enterPanel();
    }
}
