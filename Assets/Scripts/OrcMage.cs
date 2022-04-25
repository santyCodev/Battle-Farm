using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcMage : Battler
{
    public override void Initialize()
    {
        Hp = 400;
        Damage = 800;
        Name = "Orc Mage";
        BattlerClass = "Mage";
        Description = "The most powerful of his clan";
        IsEnemy = true;
    }

    public override void BattlerInfo()
    {
        base.BattlerInfo();
    }
}
