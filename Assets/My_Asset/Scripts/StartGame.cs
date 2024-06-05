using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private RawImage runImage;
    [SerializeField] private float _x, _y;
    [SerializeField] private float delay;
    public bool time;
    private void RunImage()
    {
        runImage.uvRect = new Rect(runImage.uvRect.position + new Vector2(_x, _y)*Time.deltaTime, runImage.uvRect.size);
        time = true;
    }
    private void RunReverse()
    {
        _x *= -1;
        runImage.uvRect = new Rect(runImage.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, runImage.uvRect.size);
        time = false;
    }
    private void RunBackGround()
    {
        if(time == false)
        {
            InvokeRepeating(nameof(RunReverse), delay, delay);
        }
    }
    private void Update()
    {
          RunImage();
    }

    private void Start()
    {
        RunBackGround();
    }
}
