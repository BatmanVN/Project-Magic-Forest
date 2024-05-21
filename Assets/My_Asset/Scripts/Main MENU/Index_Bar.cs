using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Index_Bar : MonoBehaviour
{
    [SerializeField] private float maxHealthbar;
    [SerializeField] private float maxPowerbar;
    [SerializeField] private float maxSpeedbar;
    [SerializeField] private float maxStarbar;

    public float MaxHealthbar { get => maxHealthbar; private set =>  maxHealthbar = value; }
    public float MaxPowerbar { get => maxPowerbar; private set => maxPowerbar = value; }
    public float MaxSpeedbar { get => maxSpeedbar; private set => maxSpeedbar = value; }
    public float MaxStarbar { get => maxStarbar; private set => maxStarbar = value; }
    private void Update()
    {
        
    }
}
