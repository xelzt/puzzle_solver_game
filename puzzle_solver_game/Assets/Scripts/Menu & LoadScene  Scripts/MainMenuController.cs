using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject secondLvlButton;
    public Image secondLvlImage;
    public Sprite[] sprites;
    private Button btn;

    private void Start()
    {
        btn = secondLvlButton.GetComponent<Button>();
        btn.interactable = (PlayerPrefs.GetInt("Lvl_1_Passed") == 1 && !btn.interactable);
        if (btn.interactable)
        {
            secondLvlImage.sprite = sprites[1];
        } else secondLvlImage.sprite = sprites[0];
    }
    public void Quit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
