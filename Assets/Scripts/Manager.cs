using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private List<Battler> battlers;

    // Start is called before the first frame update
    void Start()
    {
        battlers = new List<Battler>();
        CreateBattlers();
        InitializeBattlers();
        ShowBattlersInfo();
    }

    private void CreateBattlers()
    {        
        battlers.Add(new Warrior());    
        battlers.Add(new Priest()); 
        battlers.Add(new Archer()); 
        battlers.Add(new Mage());     
        battlers.Add(new Goblin());
        battlers.Add(new OrcMage());
        battlers.Add(new Minotaur());
        battlers.Add(new DarkPriest());
    }

    private void InitializeBattlers()
    {
        foreach (Battler battler in battlers)
        {
            battler.Initialize();
        }
    }

    private void ShowBattlersInfo()
    {
        foreach (Battler battler in battlers)
        {
            battler.BattlerInfo();
        }
        
    }
}
