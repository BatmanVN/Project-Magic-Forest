using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneHero : MonoBehaviour
{
    public void ChangeSceneHeroMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
