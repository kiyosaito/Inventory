using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Craftable", order = 6)]
public class CraftableSO : Item
{
    private void Awake()
    {
        _type = ItemType.Craftable;
    }
}
