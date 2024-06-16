using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireman_automove : MonoBehaviour
{
    private const string moveParaname = "isWalking";
    [SerializeField] private Fireman_Attack enemy;
    [SerializeField] private PointDis touch;
    [SerializeField] private Transform player;
    [SerializeField] private Animator firemanAnim;
    [SerializeField] private float speed;
    private Transform currentPoint;
    private void StartMove() //Plan 2 bot siDA
    {
        if(touch.WasTouch == true)
        {
            if (enemy.IsEnemy == false)
            {
                transform.position = Vector2.MoveTowards(transform.position, currentPoint.transform.position, speed * Time.deltaTime);
                firemanAnim.SetBool(moveParaname, true);
            }
            else
                firemanAnim.SetBool(moveParaname, false);
                return;
        }
    }
    private void Start()
    {
        currentPoint = player.transform;
    }
    private void Update()
    {
        StartMove();
    }
}
