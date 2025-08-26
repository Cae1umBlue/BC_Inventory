using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Info")]
    [SerializeField] string id;
    [SerializeField] int level;
    [SerializeField] int currentExp;
    [SerializeField] int maxExp;
    [SerializeField] string description;
    [SerializeField] int money;

    [Header("Status")]
    [SerializeField] int attack;
    [SerializeField] int defence;
    [SerializeField] int health;
    [SerializeField] int critical;

    //프로퍼티
        // Info
    public string ID => id;
    public int Level => level;
    public int CurrentExp => currentExp;
    public int MaxExp => maxExp;
    public string Description => description;
    public int Money => money;

        // Status
    public int Attack => attack;
    public int Defence => defence;
    public int Health => health;
    public int Critical => critical;

    public void SetStatus()
    {

    }
}
