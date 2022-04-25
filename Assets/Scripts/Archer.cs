using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Battler
{
    public override void Initialize()
    {
        Hp = 600;
        Damage = 700;
        Name = "Elrick";
        BattlerClass = "Archer";
        Description = "The hawkeye of the forest";
        IsEnemy = false;
    }

    public override void BattlerInfo()
    {
        base.BattlerInfo();
    }
}
