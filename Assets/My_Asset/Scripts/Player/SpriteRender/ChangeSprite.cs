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
    [SerializeField] private HealthCharacter healthCharacter;
    [SerializeField] private Mana mana;
    [SerializeField] private Player_Move speed;
    [SerializeField] private Player_skillFire starDame;
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
            if(Index == 0)
            {
                healthCharacter.HealthName = "IgHealth";
                mana.PowerKey = "IgPower";
                speed.SpeedKey = "IgSpeed";
                starDame.StarName = "IgStar";
            }
            if (Index == 1)
            {
                healthCharacter.HealthName = "AquaHealth";
                mana.PowerKey = "AuqaPower";
                speed.SpeedKey = "AquaSpeed";
                starDame.StarName = "AquaStar";
            }
            if (Index == 2)
            {
                healthCharacter.HealthName = "TerasHealth";
                mana.PowerKey = "TerasPower";
                speed.SpeedKey = "TerasSpeed";
                starDame.StarName = "TerasStar";
            }
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
