using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStatus2 : MonoBehaviour
{
    [SerializeField] private ChangeSprite_fireman status2;
    [SerializeField] private Health firemanHP;

    private void ChangeStatusVer2()
    {
        if(firemanHP.HealTH > 0 && firemanHP.HealTH <=25)
        {
            status2.ChangeStatus2();
        }
    }

    private void Update()
    {
        ChangeStatusVer2();
    }
}
