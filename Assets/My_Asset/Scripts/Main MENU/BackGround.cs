using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    [SerializeField] private RawImage backGround;
    [SerializeField] private float _x, _y;
    [SerializeField] private Player_Move moveComponent;
    [SerializeField] private StopGround stopGround;
    private void Background()
    {
        if (moveComponent.IsRight == true)
        {
            backGround.uvRect = new Rect(backGround.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, backGround.uvRect.size);
            if (stopGround.StopGroundLeft == true)
            {
                return;
            }
        }
        if(moveComponent.IsLeft == true)
        {
            backGround.uvRect = new Rect(backGround.uvRect.position + new Vector2(_x*-1, _y) * Time.deltaTime, backGround.uvRect.size);
            if (stopGround.StopGroundRight == true)
            {
                return;
            }
        }
    }

    private void Update()
    {
            
            Background();
    }
}
