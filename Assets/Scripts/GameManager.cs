using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] UIManager uiManager;
    [SerializeField] Character character;

    protected override void Initialize() 
    { 
        base.Initialize();
    }
}
