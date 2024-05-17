using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Button : MonoBehaviour
{
    [SerializeField]private Vector2 minLocation;
    [SerializeField]private Vector2 maxLocation;
    [SerializeField] private float speed;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float lefMove;
    [SerializeField] private float rightMove;
    private Vector3 dragMouse;
    public bool moveMenu;
    private void MoveMenu()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragMouse = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 changePostionMouse = dragMouse - mainCamera.ScreenToWorldPoint(Input.mousePosition);
            changePostionMouse.y = 0;
            mainCamera.transform.position += changePostionMouse;
        }
        if(mainCamera.transform.position.x <= minLocation.x)
        {
            mainCamera.transform.position = minLocation;
        }
        if(mainCamera.transform.position.x >= maxLocation.x)
        {
            mainCamera.transform.position = maxLocation;
        }
    }
    private void MoveBackGround()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lefMove = Input.mousePosition.x;
        }
        if (Input.GetMouseButtonUp(0))
        {
            rightMove = Input.mousePosition.x;
        }
        if(lefMove > rightMove)
        {
            moveMenu = true;
        }
        if (lefMove <= minLocation.x)
        {
            moveMenu = false;
        }
        if (mainCamera.transform.position.x >= maxLocation.x)
        {
            mainCamera.transform.position = maxLocation;
        }
    }
    //public void PointDown()
    //{
    //    moveMenu = true;
    //}
    //public void PointUp()
    //{
    //    moveMenu = false;
    //}
    private void Update()
    {
        MoveMenu();
    }
}
