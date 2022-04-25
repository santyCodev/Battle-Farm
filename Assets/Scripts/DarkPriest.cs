using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkPriest : Battler
{
    public override void Initialize()
    {
        Hp = 300;
        Damage = 50;
        Name = "Dark Priest";
        BattlerClass = "Priest";
        Description = "Heals with necromancy powers";
        IsEnemy = true;
    }

    public override void BattlerInfo()
    {
        base.BattlerInfo();
    }
}
