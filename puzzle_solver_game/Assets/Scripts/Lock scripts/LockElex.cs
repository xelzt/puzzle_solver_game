using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class LockElex : MonoBehaviour
{
    [SerializeField]
    private Sprite[] digits;

    [SerializeField]
    private Image[] characters;

    private string codeToBreak;
    private string codeSequence;
    private List<string> symbols = new List<string>();
    private int[] numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    private string[] mathSymbols = new[] { "<", ">", "=" };

    void Start()
    {
        codeToBreak = GenerateRandomPassword();
        dispayMathSymbols(symbols);
        codeSequence = "";
        ResetDisplay();
        PushTheButton.ButtonPressed += AddDigitToCodeSequence;
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
                    if (codeSequence.Length > 0)
                    {
                        CheckResults();
                    }
                    break;
            }
        }
    }

    private void DispayCodeSequence(int digitJustEntered)
    {
        switch (codeSequence.Length)
        {
            case 1:
                characters[0].sprite = digits[digitJustEntered];
                characters[2].sprite = digits[10];
                characters[4].sprite = digits[10];
                characters[6].sprite = digits[10];
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
    private void dispayMathSymbols(List<string> symbols)
    {
        int idx = 1;
        for (int i = 0; i < 3; i++)
        {
            if (symbols[i] == "<")
                characters[idx].sprite = digits[11]; //do doprecyzowania symbol <
            else if (symbols[i] == "=")
                characters[idx].sprite = digits[12]; //do doprecyzowania symbol =
            else
                characters[idx].sprite = digits[13]; //do doprecyzowania symbol >
            idx = idx + 2;
        }
    }

    private void CheckResults()
    {
        if (codeSequence == codeToBreak)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
            ResetDisplay();
        }
    }

    private void ResetDisplay()
    {
        codeSequence = GenerateRandomPassword();
        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[10];
        }
    }
    public List<string> generateSymbols()
    {
        for (int i = 0; i < 3; i++)
        {
            symbols.Add(mathSymbols[UnityEngine.Random.Range(0, mathSymbols.Length)]);
        }
        return symbols;
    }
    public string GenerateRandomPassword()
    {
        List<string> symbols = generateSymbols();
        int x1 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
        int x2 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
        int x3 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
        int x4 = numbers[UnityEngine.Random.Range(0, numbers.Length)];

        while (!IsValidExpression(x1, x2, x3, x4, symbols))
        {
            x1 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
            x2 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
            x3 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
            x4 = numbers[UnityEngine.Random.Range(0, numbers.Length)];
        }
        codeToBreak = x1.ToString() + x2.ToString() + x3.ToString() + x4.ToString();
        return codeToBreak;
    }

    private bool IsValidExpression(int x1, int x2, int x3, int x4, List<string> symbols)
    {
        bool firstFlag;
        bool secondFlag;
        bool thirdFlag;

        if (symbols[0] == "<")
            firstFlag = x1 < x2;
        else if (symbols[0] == "=")
            firstFlag = x1 == x2;
        else
            firstFlag = x1 > x2;

        if (symbols[1] == "<")
            secondFlag = (x2 < x3);
        else if (symbols[1] == "=")
            secondFlag = x2 == x3;
        else
            secondFlag = x2 > x3;

        if (symbols[2] == "<")
            thirdFlag = x3 < x4;
        else if (symbols[2] == "=")
            thirdFlag = x3 == x4;
        else
            thirdFlag = x3 > x4;

        if (firstFlag && secondFlag && thirdFlag)
            return true;
        else
            return false;
    }
    private void OnDestroy()
    {
        PushTheButton.ButtonPressed -= AddDigitToCodeSequence;
    }
}
