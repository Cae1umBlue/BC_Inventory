using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] GameObject uiManagerObject;
    [SerializeField] GameObject characterObject;

    public UIManager uiManager;
    public Character character;

    protected override void Initialize() 
    { 
        uiManager = uiManagerObject.AddComponent<UIManager>();
        character = characterObject.AddComponent<Character>();
    }
}
