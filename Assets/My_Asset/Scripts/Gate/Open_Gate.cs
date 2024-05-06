using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_Gate : MonoBehaviour
{
    [SerializeField] private Animator gateAnim;
    [SerializeField] private KeyGate keyGate;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask player;
    [SerializeField] private Transform pointGate;
    [SerializeField] private string sceneName;
    [SerializeField] private float delay;
    [SerializeField] private GameObject endGate;
    public bool objDisable;
    
    private void OpenGate()
    {
        var openGate = Physics2D.OverlapCircle(pointGate.position, radius, player);
        if(openGate)
        {
            if (keyGate.getKey == true)
            {
                gateAnim.SetTrigger("isOpen");
                objDisable = true;
            }
            if(objDisable == true)
            {
                endGate.SetActive(true);
            }
        }
    }
    private void ChangeScene()
    {
        if(objDisable == true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    private void Start()
    {
        InvokeRepeating(nameof(ChangeScene),delay,0);
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
