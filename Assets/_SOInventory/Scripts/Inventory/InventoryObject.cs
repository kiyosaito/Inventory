using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Scriptable Objects/Inventory")]
public class InventoryObject : ScriptableObject
{
    public ItemDatabaseObject database;
    public List<InventorySlot> Container = new List<InventorySlot>();
    public void AddItem(Item _item, int _amount)
    {
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                return;
            }
        }
        Container.Add(new InventorySlot(database.getID[_item],_item, _amount));
    }
}
[System.Serializable]
public class InventorySlot
{
    public int iD;
    public Item item;
    public int amount;
    public InventorySlot(int _iD,Item _item, int _amount)
    {
        iD = _iD;
        item = _item;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount += value;
    }
}