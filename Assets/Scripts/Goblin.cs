using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Battler
{
    public override void Initialize()
    {
        Hp = 600;
        Damage = 700;
        Name = "Goblin";
        BattlerClass = "Archer";
        Description = "The green hills terror";
        IsEnemy = true;
    }

    public override void BattlerInfo()
    {
        base.BattlerInfo();
    }
}
