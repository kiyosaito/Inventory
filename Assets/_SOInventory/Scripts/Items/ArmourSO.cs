using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Armour", order = 4)]
public class ArmourSO : Item
{
    public float defenceBonus;
    public float healthBonus;
    private void Awake()
    {
        _type = ItemType.Armour;
    }
}
