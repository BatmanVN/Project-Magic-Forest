using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{   
    private Vector2 lastPostion;
    [SerializeField] private float speed;
    public bool moveMenu;
    private void MoveMenu()
    {
        if (moveMenu == true)
        {
            lastPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(lastPostion.x*speed, lastPostion.y*0);
        }
        if (moveMenu == false)
        {
            transform.position = lastPostion;
        }
    }
    public void PointDown()
    {
        moveMenu = true;
    }
    public void PointUp()
    {
        moveMenu = false;
    }
    private void Update()
    {
        MoveMenu();
    }
}
