using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] UIManager uiManager;
    [SerializeField] Character character;

    [SerializeField] Character characterPrefab;

    public Character Player {  get; private set; }

    protected override void Initialize() 
    { 
        base.Initialize();
        SetData();
    }

    public void SetData()
    {
        Player = Instantiate(characterPrefab);
        uiManager.Status.Initialize(character);
        uiManager.MainMenu.Initialize(character);
    }
}
