using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite icon;
    public int price;

    public int extraAttack;
    public int extraDefence;
    public int extraHealth;
    public int extraCritical;

    public bool isEquipped;
}
