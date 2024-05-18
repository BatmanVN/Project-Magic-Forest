using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChange : MonoBehaviour
{
    [SerializeField] private float subsidence;
    public bool isTrigger;
    private void OnTriggerEnter2D(Collider2D ground)
    {
        if(ground.CompareTag("Player"))
        {
            isTrigger = true;
        }    
    }
    private void GroundSubsidence()
    {
        if (isTrigger == true)
        {
            Vector2 newTransform = new Vector2(transform.position.x, transform.position.y - subsidence);
            transform.position = newTransform;
            isTrigger = false;
        }
        if (isTrigger == false)
        {
            return;
        }
    }
    private void Update()
    {
        GroundSubsidence();
    }
}
