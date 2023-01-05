using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public void loadFirstLvl()
    {
        StartCoroutine(loadLevel("SceneDungeonLevel"));
    }

    public void loadSecondLvl()
    {
        StartCoroutine(loadLevel("SceneSpaceLevel"));
    }

    IEnumerator loadLevel(string levelName)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelName);
    }
}
