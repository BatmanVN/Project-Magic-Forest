using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeAuto_Move : MonoBehaviour
{
    private const string moveParaname = "skeMove";
    //[SerializeField] private Attack_Player monster;
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    [SerializeField] private Animator skeAnim;
    [SerializeField] private float speed;
    private Transform currentPoint;
    private void StartMove() //Plan 2 bot siDA
    {
            var scale = transform.localScale;
            if (Vector2.Distance(transform.position, pointB.transform.position) < 0.5f)
            {
                currentPoint = pointA.transform;
                scale.x *= -1;
            }
            if (Vector2.Distance(transform.position, pointA.transform.position) < 0.5f)
            {
                currentPoint = pointB.transform;
                scale.x *= -1;
            }
            transform.position = Vector2.MoveTowards(transform.position, currentPoint.transform.position, speed * Time.deltaTime);
            skeAnim.SetBool(moveParaname,true);
            transform.localScale = scale;
    }
    private void Start()
    {
        currentPoint = pointB.transform;
        //monster2D.velocity = new Vector2(speed, 0);
    }
    private void Update()
    {
        StartMove();
        //AutoMoveMonster();
    }
}

