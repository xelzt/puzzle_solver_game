using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AICanvaManager : MonoBehaviour
{

    private bool FirstTimeEnabled = false;
    public Canvas AICanva, DialogBoxInfoCanva;
    public Text DisplayTextBox;
    public string DisplayTextValue;
    private bool isDialogBoxInfoCanvaActive = false;

    private void Awake()
    {
        DisplayTextBox.text = DisplayTextValue;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isDialogBoxInfoCanvaActive)
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
