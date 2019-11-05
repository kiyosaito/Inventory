using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Ingredient", order = 0)]
public class IngredientSO : Item
{
    private void Awake()
    {
        _type = ItemType.Ingredient;
    }
}
