using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public string sceneName;
    public void loadLvl()
    {
        LevelLoader.Instance.ChangeScene(sceneName);
    }
}
