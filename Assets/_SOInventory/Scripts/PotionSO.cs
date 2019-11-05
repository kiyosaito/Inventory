using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Potion", order = 1)]
public class PotionSO : Item
{
    private void Awake()
    {
        _type = ItemType.Potion;
    }
}
