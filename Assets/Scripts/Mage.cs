using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Battler
{
    public override void Initialize()
    {
        Hp = 400;
        Damage = 800;
        Name = "Kazin";
        BattlerClass = "Mage";
        Description = "The most powerful elve mage";
        IsEnemy = false;
    }

    public override void BattlerInfo()
    {
        base.BattlerInfo();
    }
}
