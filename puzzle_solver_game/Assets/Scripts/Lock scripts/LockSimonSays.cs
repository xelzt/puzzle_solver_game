using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
public class LockSimonSays : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
    [SerializeField] GameObject[] lightArray;
    [SerializeField] GameObject[] rowLights;
    [SerializeField] int[] lightOrder;
    [SerializeField] GameObject simonSaysGamePanel;
    [SerializeField] GameObject windowsPanel;
    public Camera simonSaysGamePanelCam;
    int level = 0;
    int buttonsclicked = 0;
    int colorOrderRunCount = 0;
    bool passed = false;
    Color32 red = new Color32(255, 39, 0, 255);
    Color32 black = new Color32(0, 0, 0, 255);
    Color32 green = new Color32(4, 204, 0, 255);
    Color32 invisible = new Color32(4, 204, 0, 0);
    Color32 white = new Color32(255, 255, 255, 255);
    public float lightspeed;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            simonSaysGamePanel.SetActive(false);
        }
    }
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("DidSimonSaysQuest") != 1)
        {
            buttonsclicked = 0;
            colorOrderRunCount = -1;
            level = 1;
            GeneratePassword();
            ResetLEDs();
            StartCoroutine(ColorOrder());
        }
    }
    private void ResetLEDs()
    {
        for (int i = 0; i < rowLights.Length; i++)
        {
            rowLights[i].GetComponent<Image>().color = white;
        }
    }
    private void GeneratePassword()
    {
        for (int i = 0; i < lightOrder.Length; i++)
        {

            lightOrder[i] = (UnityEngine.Random.Range(0, 9));
        }
    }
    public void ButtonClickOrder(int button)
    {
        buttonsclicked++;
        if (button == lightOrder[buttonsclicked - 1])
        {
            passed = true;
        }
        else
        {
            passed = false;
            StartCoroutine(ColorBlink());
        }
        if (buttonsclicked == level && passed == true && buttonsclicked != 5)
        {
            level++;
            passed = false;
            StartCoroutine(ColorOrder());
        }
        if (buttonsclicked == level && passed == true && buttonsclicked == 5)
        {
            PlayerPrefs.SetInt("DidSimonSaysQuest", 1);
            PlayerPrefs.Save();
            DisableInteractableButtons();
            simonSaysGamePanel.SetActive(false);
        }
    }
    IEnumerator ColorBlink()
    {
        DisableInteractableButtons();
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < lightArray.Length; i++)
            {
                lightArray[i].GetComponent<Image>().color = red;
            }
            yield return new WaitForSeconds(lightspeed);
            for (int i = 0; i < lightArray.Length; i++)
            {
                lightArray[i].GetComponent<Image>().color = black;
            }
            yield return new WaitForSeconds(lightspeed);
        }
        EnableInteractableButtons();
        OnEnable();
    }
    IEnumerator ColorOrder()
    {
        buttonsclicked = 0;
        colorOrderRunCount++;
        DisableInteractableButtons();
        for (int i = 0; i <= colorOrderRunCount; i++)
        {
            if (level >= colorOrderRunCount)
            {
                yield return new WaitForSeconds(lightspeed);
                lightArray[lightOrder[i]].GetComponent<Image>().color = green;
                yield return new WaitForSeconds(lightspeed);
                lightArray[lightOrder[i]].GetComponent<Image>().color = invisible;
                rowLights[i].GetComponent<Image>().color = green;
            }
        }
        EnableInteractableButtons();
    }
    void DisableInteractableButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = false;
        }
    }
    void EnableInteractableButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = true;
        }
    }
}