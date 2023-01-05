using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Animator transition;
    public GameObject LoadGamePanel;
    public float transitionTime = 1f;

    public void openSelectLevel()
    {
        LoadGamePanel.SetActive(true);
    }
    public void closeSelectLevel()
    {
        LoadGamePanel.SetActive(false);
    }

    public void loadFirstLvl()
    {
        SceneManager.LoadScene("SceneDungeonLevel");
        SceneManager.UnloadSceneAsync("SceneMainMenu");
    }

    public void loadSecondLvl()
    {
        SceneManager.LoadScene("SceneSpaceLevel");
    }
    public void Quit()
    {
        Debug.Log("quited");
        Application.Quit();
    }
}
