using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class LockSimonSaysV2 : MonoBehaviour
{
    [SerializeField]
    private Sprite[] digits;
    [SerializeField]
    private Image[] characters;
    [SerializeField] 
    private GameObject[] buttons;

    private string codeToBreak;
    private string codeSequence;
    private int level = 1;
    private int[] numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    void Start()
    {
        codeToBreak = GenerateRandomPassword();
        ResetDisplay();
        PushTheButton.ButtonPressed += AddDigitToCodeSequence;
    }

    private void AddDigitToCodeSequence(string digitEntered)
    {
        if (codeSequence.Length < level)
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
            }
        }
        if (codeSequence.Length == 5)
        {
            CheckResults();
        }
    }

    private void DispayCodeSequence(int digitJustEntered)
    {
        switch (codeSequence.Length)
        {
            case 1:
                characters[0].sprite = digits[digitJustEntered];
                characters[1].sprite = digits[digitJustEntered];
                characters[2].sprite = digits[10];
                characters[3].sprite = digits[10];
                characters[4].sprite = digits[10];
                characters[5].sprite = digits[10];
                characters[6].sprite = digits[10];
                characters[7].sprite = digits[10];
                characters[8].sprite = digits[10];
                characters[9].sprite = digits[10];
                break;
            case 2:
                characters[0].sprite = digits[digitJustEntered];
                characters[2].sprite = characters[6].sprite;
                characters[4].sprite = digits[10];
                characters[6].sprite = digits[10];
                break;
            case 3:
                characters[0].sprite = digits[digitJustEntered];
                characters[2].sprite = characters[6].sprite;
                characters[4].sprite = characters[4].sprite;
                characters[6].sprite = digits[10];
                break;
            case 4:
                characters[0].sprite = digits[digitJustEntered];
                characters[2].sprite = characters[6].sprite;
                characters[4].sprite = characters[4].sprite;
                characters[6].sprite = characters[2].sprite;
                break;

        }
    }
    private void CheckResults()
    {
        if (codeSequence == codeToBreak)
        {
            Debug.Log("Correct!");
            PlayerPrefs.SetInt("DidSimonSays", 1);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.Log("Wrong!");
            ResetDisplay();
        }
    }

    private void ResetDisplay()
    {
        codeSequence = "";
        codeToBreak = GenerateRandomPassword();
        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[10];
        }
    }
    public string GenerateRandomPassword()
    {
        int x1 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
        int x2 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
        int x3 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
        int x4 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
        int x5 = numbers[UnityEngine.Random.Range(0, numbers.Length)];

        codeToBreak = x1.ToString() + x2.ToString() + x3.ToString() + x4.ToString();
        return codeToBreak;
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
    private void OnDestroy()
    {
        PushTheButton.ButtonPressed -= AddDigitToCodeSequence;
    }
}
