using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    [SerializeField] private RawImage backGround;
    [SerializeField] private float _x, _y;
    [SerializeField] private float speed;

    private void Background()
    {
        backGround.uvRect = new Rect(backGround.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, backGround.uvRect.size);
        if (backGround.uvRect.x == 0.5)
        {
            _x *= -1;
            //backGround.uvRect = new Rect(backGround.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, backGround.uvRect.size);
        }
    }
    private void Update()
    {
            //returnBackground();
            Background();
    }
}
