using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject secondLvlButton;
    private Button btn;

    private void Start()
    {
        btn = secondLvlButton.GetComponent<Button>();
        btn.interactable = (PlayerPrefs.GetInt("Lvl_1_Passed") == 1 && !btn.interactable);
    }
    public void Quit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
