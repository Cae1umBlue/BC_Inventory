using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] UIManager uiManager;
    public Character Player {  get; private set; }

    protected override void Initialize() 
    { 
        base.Initialize();
        SetData();
    }

    public void SetData()
    {
        Player = new Character("Mina", 01, "각종 무술 유단자", 10, 5, 100, 3, 1000);

        ItemData cloth = Resources.Load<ItemData>("ItemDatas/Cloth");

        Player.Additem(cloth);

        uiManager.Status.Initialize(Player);
        uiManager.MainMenu.Initialize(Player);
        uiManager.Inventory.Initialize(Player);
    }
}
