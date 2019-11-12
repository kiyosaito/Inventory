using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Quest", order = 7)]
public class QuestSO : Item
{
    private void Awake()
    {
        _type = ItemType.Quest;
    }
}
