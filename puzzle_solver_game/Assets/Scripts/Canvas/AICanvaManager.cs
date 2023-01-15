using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AICanvaManager : MonoBehaviour
{

    private bool FirstTimeEnabled = false;
    public Canvas AICanva, DialogBoxInfoCanva;
    private Text DisplayTextBox;
    public string DisplayTextValue;
    private bool isDialogBoxInfoCanvaActive = false;
    private Canvas DialogBoxInfoCanvaCopy;

    private void Awake()
    {
        DialogBoxInfoCanva = DialogBoxInfoCanva.GetComponent<Canvas>();
        DialogBoxInfoCanvaCopy = DialogBoxInfoCanva.GetComponent<Canvas>();
    }

    private void Update()
    {
        //If dialog is once open make possible to re-open it.
        if (Input.GetKeyDown(KeyCode.F) && isDialogBoxInfoCanvaActive)
        {
            DialogBoxInfoCanva.gameObject.SetActive(false);
            AICanva.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!FirstTimeEnabled)
        {
            AICanva = Instantiate(AICanva).GetComponent<Canvas>();
            DisplayTextBox = AICanva.GetComponentInChildren<Text>();
            DisplayTextBox.text = DisplayTextValue;
            AICanva.gameObject.SetActive(true);
            FirstTimeEnabled = true;

        }
        else
        {
            DialogBoxInfoCanva = Instantiate(DialogBoxInfoCanva).GetComponent<Canvas>();
            DialogBoxInfoCanva.gameObject.SetActive(true);   
            isDialogBoxInfoCanvaActive = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (!FirstTimeEnabled) 
        {
            if(!AICanva.gameObject.activeInHierarchy)
            {
                Destroy(AICanva.gameObject, 0.2f);
            }
        }
        else
        {
            isDialogBoxInfoCanvaActive = false;
            if (DialogBoxInfoCanva.gameObject.activeInHierarchy)
            {
                DialogBoxInfoCanva.gameObject.SetActive(false);
                Destroy(DialogBoxInfoCanva.gameObject, 0.2f);
                DialogBoxInfoCanva = DialogBoxInfoCanvaCopy;
            }
        }
        
    }

}
