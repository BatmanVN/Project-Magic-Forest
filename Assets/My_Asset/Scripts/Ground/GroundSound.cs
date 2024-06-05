using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSound : MonoBehaviour
{
    [SerializeField] private AudioSource groundKit;
    private void OnTriggerEnter2D(Collider2D ground)
    {
        
    }
    private void Start()
    {
        groundKit.enabled = false;
    }
}
