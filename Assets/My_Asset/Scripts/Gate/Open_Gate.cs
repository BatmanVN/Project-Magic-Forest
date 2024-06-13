using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_Gate : MonoBehaviour
{
    [SerializeField] private string sceneAgain;
    [SerializeField] private string sceneHome;
    [SerializeField] private EndGateBar chest;
    [SerializeField] private Animator gateAnim;
    [SerializeField] private KeyGate keyGate;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask player;
    [SerializeField] private Transform pointGate;
    [SerializeField] private GameObject endGate;
    [SerializeField] private string gateName;
    [SerializeField] private int gateNumber;
    [ContextMenu("SaveGate")]
    private void OpenGate()
    {
        var openGate = Physics2D.OverlapCircle(pointGate.position, radius, player);
        if(openGate)
        {
            if (keyGate.GetKey == true)
            {
                gateAnim.SetTrigger("isOpen");
                SaveData();
                StartCoroutine(Delay());
            }
        }
    }
    private void SaveData()
    {
        PlayerPrefs.SetInt(gateName, gateNumber);
    }
    private void EnableBar()
    {
        endGate.SetActive(true);
        chest?.RewardChest();
        Time.timeScale = 0;
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        EnableBar();
    }
    public void SelectScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
    private void Update()
    {
        OpenGate();
    }

    private void OnDrawGizmos()
    {
          Gizmos.color = Color.black;
          Gizmos.DrawWireSphere(pointGate.position, radius);
    }
}
