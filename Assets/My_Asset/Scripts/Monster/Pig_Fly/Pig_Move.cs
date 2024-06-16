using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig_Move : MonoBehaviour
{
    [SerializeField] private Health pigHealth;
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    [SerializeField] private GameObject pointDie;
    [SerializeField] private Animator pigAnim;
    [SerializeField] private float speed;
    private Transform currentPoint;
    private void AutoMove()
    {
        var pigScale = transform.localScale;
        if (Vector2.Distance(transform.position, pointA.transform.position) < 0.5f)
        {
            currentPoint = pointB.transform;
            pigScale.x = -1.3f;
        }
        if (Vector2.Distance(transform.position, pointB.transform.position) < 0.5f)
        {
            currentPoint = pointA.transform;
            pigScale.x = 1.3f;
        }
        if(pigHealth.isDead)
        {
            currentPoint = pointDie.transform;
        }
        transform.position = Vector2.MoveTowards(transform.position,currentPoint.transform.position,speed*Time.deltaTime);
        pigAnim.SetTrigger("isFly");
        transform.localScale = pigScale;
    }
    private void Start()
    {
        currentPoint = pointA.transform;
    }
    private void Update()
    {
        AutoMove();
    }
}
