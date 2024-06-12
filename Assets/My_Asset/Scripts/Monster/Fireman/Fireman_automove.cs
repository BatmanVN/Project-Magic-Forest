using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireman_automove : MonoBehaviour
{
    private const string moveParaname = "fireManMove";
    [SerializeField] private Transform attackPostion;
    [SerializeField] private float rangeAttk;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private Transform player;
    [SerializeField] private Animator firemanAnim;
    [SerializeField] private float speed;
    private Transform currentPoint;
    private void StartMove() //Plan 2 bot siDA
    {
        var hit = Physics2D.OverlapCircle(attackPostion.position, rangeAttk, playerMask);
        if (!hit)
        {
            transform.position = Vector2.MoveTowards(transform.position, currentPoint.transform.position, speed * Time.deltaTime);
            firemanAnim.SetBool(moveParaname, true);
        }
        else
            return;
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
