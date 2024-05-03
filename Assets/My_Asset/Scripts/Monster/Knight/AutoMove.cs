using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    [SerializeField] private Rigidbody2D monster2D;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator monsterAnim;
    [SerializeField] private float speed;
    private Transform currentPoint;    
    private void AutoMoveMonster()
    {
        var scale = transform.localScale;
       if(currentPoint == pointA.transform)
        {
            monster2D.velocity = new Vector2(-speed,0);
        }
       if(currentPoint == pointB.transform)
        {
            monster2D.velocity = new Vector2(speed,0);
        }
       if(Vector2.Distance(transform.position,currentPoint.position) < 1f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
            scale.x = (float)1.4;
        }
       if(Vector2.Distance(transform.position,currentPoint.position)< 1f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;
            scale.x = (float)-1.4;
        }
       transform.localScale = scale;
    }
    private void StartMove()
    {
        currentPoint = pointB.transform;
    }
    private void Start()
    {
        monster2D = GetComponent<Rigidbody2D>();
        StartMove();
    }
    private void Update()
    {
        AutoMoveMonster();
    }
}
