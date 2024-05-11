using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    [SerializeField] private RawImage backGround;
    [SerializeField] private float _x, _y;
    [SerializeField] private Player_Move moveComponent;
    private void Background()
    {
        var scale = transform.localScale;
        if (moveComponent.isRight == true)
        {
            backGround.uvRect = new Rect(backGround.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, backGround.uvRect.size);
            if (moveComponent.stopGroundLeft == true)
            {
                return;
            }
        }
        if(moveComponent.isLeft == true)
        {
            backGround.uvRect = new Rect(backGround.uvRect.position + new Vector2(_x*-1, _y) * Time.deltaTime, backGround.uvRect.size);
            if (moveComponent.stopGroundRight == true)
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
