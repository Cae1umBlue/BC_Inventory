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
}
