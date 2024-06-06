using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeAuto_Move : MonoBehaviour
{
    private const string moveParaname = "skeMove";
    [SerializeField] private SkeAuto_Move move;
    [SerializeField] private Health skeHealth;
    [SerializeField] private Transform player;
    [SerializeField] private Animator skeAnim;
    [SerializeField] private float speed;
    private Transform currentPoint;


    public void ChangeSpeed(float speedChange)
    {
            speed += speedChange;
    }
    private void StartMove() //Plan 2 bot siDA
    {
            var scale = transform.localScale;
            transform.position = Vector2.MoveTowards(transform.position, currentPoint.transform.position, speed * Time.deltaTime);
            skeAnim.SetBool(moveParaname,true);
            if (skeHealth.isDead)
            {
                move.enabled = false;
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

