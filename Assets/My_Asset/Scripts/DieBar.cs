using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieBar : MonoBehaviour
{
    [SerializeField] private string sceneHome;
    [SerializeField] private string sceneSpawn;
    [SerializeField] private HealthCharacter character;
    [SerializeField] private GameObject dieBar;

    private void EnableDieBar()
    {
        dieBar.SetActive(true);
        Time.timeScale = 0;
    }
    public void EnableBar()
    {
        StartCoroutine(Delay());
    }
    public void ClickButton(string sceneName)
    {
            SceneManager.LoadScene(sceneName);
            Time.timeScale = 1;
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.9f);
        EnableDieBar();
    }
    private void Update()
    {

    }
}
