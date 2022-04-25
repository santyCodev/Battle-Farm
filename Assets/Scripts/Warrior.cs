using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Battler
{    
    public override void Initialize()
    {
        Hp = 1000;
        Damage = 200;
        Name = "Bowie";
        BattlerClass = "Warrior";
        Description = "The last fighter of Granseal Kingdom";
        IsEnemy = false;
    }

    public override void BattlerInfo()
    {
        base.BattlerInfo();
    }
}
