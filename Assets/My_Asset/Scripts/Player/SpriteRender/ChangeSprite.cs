using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    [SerializeField] private Sprite[] spriteRenderers;
    [SerializeField] private SpriteRenderer characterSprite;
    [SerializeField] private string keyName;
    [SerializeField] private int index;
    [SerializeField] private AnimatorController[] heroAnim;
    [SerializeField] private Animator player;

    public int Index { get => index; set => index = value; }

    [ContextMenu("Get")]
    private void Awake()
    {
        Get();
    }
    public void ChooseSprite()
    {
        if(Index >= 0 && Index < spriteRenderers.Length)
        {
            characterSprite.sprite = spriteRenderers[Index];
            player.runtimeAnimatorController = heroAnim[Index];
        }
        else
        {
            return;
        }
    }
    private int Get()
    {
        Index = PlayerPrefs.GetInt(keyName, Index);
        return Index;
    }
    private void Start()
    {
        ChooseSprite();
    }
}
