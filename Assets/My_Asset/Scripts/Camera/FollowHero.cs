using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHero : MonoBehaviour
{
    [SerializeField] private EnalbeHero enalbeHero;
    [SerializeField] private Transform[] heroes;

    private void Awake()
    {
        Follow();
    }
    private void Follow()
    {
        if(enalbeHero.Index == 0)
        {
            transform.LookAt(heroes[0]);
        }
        if(enalbeHero.Index == 1)
        {
            transform.LookAt(heroes[1]);
        }
    }
}
