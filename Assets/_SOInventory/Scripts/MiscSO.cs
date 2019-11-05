using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Misc", menuName = "Scriptable Objects/Misc", order = 8)]
public class MiscSO : Item
{
    private void Awake()
    {
        _type = ItemType.Misc;
    }
}
