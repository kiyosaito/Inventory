using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Item",menuName ="Scriptable Objects",order =1)]
public class Item : ScriptableObject
{
    public string _name;
    public int _iD;
    public GameObject _prefab;
    public ItemType _type;
    public int _amount;
    public int _value;
    private Sprite _icon;
    [TextArea(15, 20)]
    public string description;

}
public enum ItemType
{
    Ingredient,
    Potion,
    Scroll,
    Food,
    Armour,
    Weapon,
    Craftable,
    Quest,
    Misc
}
