using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LockDigit : MonoBehaviour
{
    [SerializeField]
    private Sprite[] digits;

    [SerializeField]
    private Image[] characters;
    [SerializeField]
    GameObject canvasPanel;
    [SerializeField]
    GameObject codeHint;
    private Image hintImage;

    private string codeSequence;

    void Start()
    {
        hasHint();
        codeSequence ="";
        hintImage = codeHint.GetComponent<Image>();
        ResetDisplay();

        PushTheButton.ButtonPressed += AddDigitToCodeSequence;
    }

    void Update()
    {
        escape();
        hasHint();


    }
    private void escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvasPanel.SetActive(false);
        }
    }
    private void hasHint()
    {
        for (int i = 0; i < Inventory.Instance.itemList.Count; i++)
        {
            hintImage.enabled = true ? Inventory.Instance.itemList[i].itemName == "codeHint" : false;
        }
    }

    private void AddDigitToCodeSequence(string digitEntered)
    {
        if (codeSequence.Length < 4)
        {
            switch (digitEntered)
            {
                case "Zero":
                    codeSequence += "0";
                    DispayCodeSequence(0);
                    break;
                case "One":
                    codeSequence += "1";
                    DispayCodeSequence(1);
                    break;
                case "Two":
                    codeSequence += "2";
                    DispayCodeSequence(2);
                    break;
                case "Three":
                    codeSequence += "3";
                    DispayCodeSequence(3);
                    break;
                case "Four":
                    codeSequence += "4";
                    DispayCodeSequence(4);
                    break;
                case "Five":
                    codeSequence += "5";
                    DispayCodeSequence(5);
                    break;
                case "Six":
                    codeSequence += "6";
                    DispayCodeSequence(6);
                    break;
                case "Seven":
                    codeSequence += "7";
                    DispayCodeSequence(7);
                    break;
                case "Eight":
                    codeSequence += "8";
                    DispayCodeSequence(8);
                    break;
                case "Nine":
                    codeSequence += "9";
                    DispayCodeSequence(9);
                    break;
                case "Null":
                    codeSequence += "0";
                    DispayCodeSequence(0);
                    break;
            }
        }
        if (codeSequence.Length == 4)
        {
            switch (digitEntered)
            {
                case "Star":
                    ResetDisplay();
                    break;
                case "Hash":
                    CheckResults();
                    break;
            }
        }
    }

    private void DispayCodeSequence(int digitJustEntered)
    {
        switch (codeSequence.Length)
        {
            case 1:
                characters[0].sprite = digits[10];
                characters[1].sprite = digits[10];
                characters[2].sprite = digits[10];
                characters[3].sprite = digits[digitJustEntered];
                break;
            case 2:
                characters[0].sprite = digits[10];
                characters[1].sprite = digits[10];
                characters[2].sprite = characters[3].sprite;
                characters[3].sprite = digits[digitJustEntered];
                break;
            case 3:
                characters[0].sprite = digits[10];
                characters[1].sprite = characters[2].sprite;
                characters[2].sprite = characters[3].sprite;
                characters[3].sprite = digits[digitJustEntered];
                break;
            case 4:
                characters[0].sprite = characters[1].sprite;
                characters[1].sprite = characters[2].sprite;
                characters[2].sprite = characters[3].sprite;
                characters[3].sprite = digits[digitJustEntered];
                break;
            
        }
    }

    private void CheckResults()
    {
        if (codeSequence == "2137")
        {
            PlayerPrefs.SetInt("DidDigitQuest", 1);
            PlayerPrefs.Save();
            canvasPanel.SetActive(false);
        }
        else
        {
            ResetDisplay();
        }
    }

    private void ResetDisplay()
    {   
        codeSequence ="";
        for (int i = 0; i <= characters.Length -1; i++)
        {
            characters[i].sprite = digits[10];
        }
    }

    private void OnDestroy()
    {
        PushTheButton.ButtonPressed -= AddDigitToCodeSequence;
    }
}
