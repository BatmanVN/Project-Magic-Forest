using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    [SerializeField] private Attack_Player monster;
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    [SerializeField] private Animator monsterAnim;
    [SerializeField] private float speed;
    private Transform currentPoint;
    private void StartMove() //Plan 2 bot siDA
    {
        var scale = transform.localScale;
        if (Vector2.Distance(transform.position, pointB.transform.position) < 0.3f)
        {
            currentPoint = pointA.transform;
            scale.x *= -1;
        }
        if (Vector2.Distance(transform.position, pointA.transform.position) < 0.3f)
        {
            currentPoint = pointB.transform;
            scale.x *= -1;
        }
        if (scale.x > 0 && monster.isAttk == true)
        {
            currentPoint = pointB.transform;
        }
        if (scale.x < 0  && monster.isAttk == true)
        {
            currentPoint = pointA.transform;
        }
        transform.position = Vector2.MoveTowards(transform.position, currentPoint.transform.position, speed * Time.deltaTime);
        transform.localScale = scale;
    }
    private void Start()
    {
        currentPoint = pointB.transform;
    }
    private void Update()
    {
        StartMove();
    }
}
