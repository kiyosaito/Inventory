using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Food", order = 3)]
public class FoodSO : Item
{
    private void Awake()
    {
        _type = ItemType.Food;
    }
}
