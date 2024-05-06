using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_Gate : MonoBehaviour
{
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
            }
        }
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
