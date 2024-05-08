using System.Collections;
using System.Collections.Generic;
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
    private void OpenGate()
    {
        var openGate = Physics2D.OverlapCircle(pointGate.position, radius, player);
        if(openGate)
        {
            if (keyGate.getKey == true)
            {
                gateAnim.SetTrigger("isOpen");
                endGate.SetActive(true);
                chest?.RewardChest();
                Time.timeScale = 0;
            }
        }
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(sceneAgain);
        Time.timeScale = 1;
    }
    public void Home()
    {
        SceneManager.LoadScene(sceneHome);
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
