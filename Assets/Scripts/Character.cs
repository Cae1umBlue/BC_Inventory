using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    // Info
    public string CharacterName { get; private set; }
    public int Level { get; private set; }
    public int CurrentExp { get; private set; }
    public int MaxExp { get; private set; }
    public string Description { get; private set; }
    public int Money { get; private set; }

    // Status
    public int Attack { get; private set; }
    public int Defence { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }


    public List<ItemData> Inventory { get; private set; }

    public Character(string characterName, int level, string description,
                     int attack, int defence, int health, int critical, int money = 0, int currentExp = 7, int maxExp = 10)
    {
        CharacterName = characterName;
        Level = level;
        Description = description;
        Attack = attack;
        Defence = defence;
        Health = health;
        Critical = critical;
        Money = money;
        Inventory = new List<ItemData>();
    }

    public void Additem(ItemData itemData)
    {
        if (itemData == null) return;
        Inventory.Add(itemData);
    }

    public void Equip(ItemData itemData)
    {
        if (!Inventory.Contains(itemData)) return;
        itemData.isEquipped = true;

        Attack += itemData.extraAttack;
        Defence += itemData.extraDefence;
        Health += itemData.extraHealth; 
        Critical += itemData.extraCritical;
    }

    public void UnEquip(ItemData itemData)
    {
        if (!Inventory.Contains(itemData)) return;
        itemData.isEquipped = false;

        Attack -= itemData.extraAttack;
        Defence -= itemData.extraDefence;
        Health -= itemData.extraHealth;
        Critical -= itemData.extraCritical;
    }
}
