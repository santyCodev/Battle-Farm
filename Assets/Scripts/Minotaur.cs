using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur : Battler
{
    public override void Initialize()
    {
        Hp = 1000;
        Damage = 200;
        Name = "Minotaur";
        BattlerClass = "Warrior";
        Description = "The undefeated monster";
        IsEnemy = true;
    }

    public override void BattlerInfo()
    {
        base.BattlerInfo();
    }
}
