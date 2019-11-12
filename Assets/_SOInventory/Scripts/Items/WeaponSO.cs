using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Weapon", order = 5)]
public class WeaponSO : Item
{
    public float attackBonus;
    private void Awake()
    {
        _type = ItemType.Weapon;
    }
}
