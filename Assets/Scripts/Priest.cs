using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : Battler
{
    public override void Initialize()
    {
        Hp = 300;
        Damage = 50;
        Name = "Sarah";
        BattlerClass = "Priest";
        Description = "Holy and elemental powers";
        IsEnemy = false;
    }

    public override void BattlerInfo()
    {
        base.BattlerInfo();
    }
}
