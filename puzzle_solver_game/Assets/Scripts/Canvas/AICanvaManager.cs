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

    private void Awake()
    {
        //Get Textbox where text will be displayed
        AICanva = Instantiate(AICanva).GetComponent<Canvas>();
        DialogBoxInfoCanva = Instantiate(DialogBoxInfoCanva).GetComponent<Canvas>();
        DisplayTextBox = AICanva.GetComponentInChildren<Text>();
        DisplayTextBox.text = DisplayTextValue;
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

            AICanva.gameObject.SetActive(true);
            FirstTimeEnabled = true;

        }
        else
        {
            DialogBoxInfoCanva.gameObject.SetActive(true);            
            isDialogBoxInfoCanvaActive = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        DialogBoxInfoCanva.gameObject.SetActive(false);
        isDialogBoxInfoCanvaActive = false;
    }

}
