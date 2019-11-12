using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Scroll", order = 2)]
public class ScrollSO : Item
{
    private void Awake()
    {
        _type = ItemType.Scroll;
    }
}
