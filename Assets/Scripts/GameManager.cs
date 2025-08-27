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
        SetInventoryItem();    
        uiManager.Status.Initialize(Player);
        uiManager.MainMenu.Initialize(Player);
        uiManager.Inventory.Initialize(Player);
    }

    public void SetInventoryItem() // 인벤토리 아이템 데이터 추가
    {
        string[] itemNames = {
        "axe", "belts", "boots", "gloves", "helmets",
        "necklace", "pants", "rings", "shield", "shoulders", "sword"
        };

        foreach (var itemName in itemNames)
        {
            ItemData item = Resources.Load<ItemData>($"ItemDatas/{itemName}");

            if (item != null)
                Player.Additem(item);
        }
    }
}
