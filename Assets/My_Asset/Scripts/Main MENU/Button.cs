using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private Vector2 lastpostion;
    private Vector2 minLocation;
    private Vector2 maxLocation;
    [SerializeField] private float speed;
    public bool moveMenu;
    private void MoveMenu()
    {
        var minX = minLocation.x;
        var maxX = maxLocation.x;
        if (moveMenu == true)
        {
            speed += 1;
            if(minX <= 5.2f || maxX >= 16.5f)
            {
                return;
            }
            transform.position = new Vector2(transform.position.x*speed, transform.position.y*0);
        }
        if (moveMenu == false)
        {
            transform.position = lastpostion;
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
