using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Battler : MonoBehaviour
{
    private int hp;
    private int damage;
    public bool IsEnemy { get; set; }
    public string BattlerClass { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public int Hp
    {
        get { return hp; }
        set 
        { 
            if(value >= 0) { hp = value; }
            else { hp = 0; }
        }            
    }

    public int Damage 
    {
        get { return damage; }
        set 
        {
            if(value >= 0){ damage = value; }
            else { damage = 0;}
        }
    }

    public abstract void Initialize();

    public virtual void BattlerInfo()
    {
        Debug.Log("Name: "+Name
                +", Class: "+BattlerClass
                +", Description: "+Description
                +", Hp: "+Hp+", Damage: "+Damage);
    }

}
