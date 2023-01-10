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
    int level = 0;
    int buttonsclicked = 0;
    int colorOrderRunCount = 0;
    bool passed = false;
    bool won = false;
    Color32 red = new Color32(255, 39, 0, 255);
    Color32 green = new Color32(4, 204, 0, 255);
    Color32 invisible = new Color32(4, 204, 0, 0);
    Color32 white = new Color32(255, 255, 255, 255);
    public float lightspeed;

    private void OnEnable()
    {
        level = 0;
        buttonsclicked = 0;
        colorOrderRunCount = -1;
        won = false;
        for (int i = 0; i < lightOrder.Length; i++)
        {

            lightOrder[i] = (UnityEngine.Random.Range(0, 8));
        }
        for (int i = 0; i < rowLights.Length; i++)
        {
            rowLights[i].GetComponent<Image>().color = white;
        }
        level = 1;
        StartCoroutine(ColorOrder());
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
            won = false;
            passed = false;
            StartCoroutine(ColorBlink(red));
        }
        if (buttonsclicked == level && passed == true && buttonsclicked != 5)
        {
            level++;
            passed = false;
            StartCoroutine(ColorOrder());
        }
        if (buttonsclicked == level && passed == true && buttonsclicked == 5)
        {
            won = true;
            StartCoroutine(ColorBlink(green));
        }
    }
    public void ClosePanel()
    {
        simonSaysGamePanel.SetActive(false);
    }
    public void OpenPanel()
    {
        simonSaysGamePanel.SetActive(true);
    }
    IEnumerator ColorBlink(Color32 colorToBlink)
    {
        DisableInteractableButtons();
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Image>().color = colorToBlink;
            }
            for (int i = 5; i < rowLights.Length; i++)
            {
                rowLights[i].GetComponent<Image>().color = colorToBlink;
            }
            yield return new WaitForSeconds(.5f);
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Image>().color = white;
            }
            for (int i = 5; i < rowLights.Length; i++)
            {
                rowLights[i].GetComponent<Image>().color = white;
            }
            yield return new WaitForSeconds(.5f);
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
                lightArray[lightOrder[i]].GetComponent<Image>().color = invisible;
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