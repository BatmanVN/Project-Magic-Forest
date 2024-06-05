using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeAuto_Move : MonoBehaviour
{
    private const string moveParaname = "skeMove";
    //[SerializeField] private Attack_Player monster;
    [SerializeField] private Transform player;
    [SerializeField] private Animator skeAnim;
    [SerializeField] private float speed;
    private Transform currentPoint;
    private bool isChange;

    public bool IsChange { get => isChange; set => isChange = value; }

    public void ChangeSpeed(float speedChange)
    {
        if(IsChange == false)
        {
            speed += speedChange;
            IsChange = true;
        }
    }
    private void StartMove() //Plan 2 bot siDA
    {
            var scale = transform.localScale;
            transform.position = Vector2.MoveTowards(transform.position, currentPoint.transform.position, speed * Time.deltaTime);
            skeAnim.SetBool(moveParaname,true);
            //transform.localScale = scale;
    }
    private void Start()
    {
        currentPoint = player.transform;
        //monster2D.velocity = new Vector2(speed, 0);
    }
    private void Update()
    {
        StartMove();
        //AutoMoveMonster();
    }
}

