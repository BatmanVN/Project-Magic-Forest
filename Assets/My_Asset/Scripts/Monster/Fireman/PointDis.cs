using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointDis : MonoBehaviour
{
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    private void OnTriggerEnter2D(Collider2D pointDis)
    {
        if(pointDis.CompareTag("Player"))
        {
            pointA.SetActive(true);
            pointB.SetActive(true);
        }
    }
}
