using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointDis : MonoBehaviour
{
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB; 
    private bool wasTouch;

    public bool WasTouch { get => wasTouch; set => wasTouch = value; }

    private void OnTriggerEnter2D(Collider2D pointDis)
    {
        if(pointDis.CompareTag("Player"))
        {
            wasTouch = true;
            pointA.SetActive(true);
            pointB.SetActive(true);
        }
    }
}
