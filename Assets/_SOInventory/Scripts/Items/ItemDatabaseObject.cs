using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Database",menuName = "Scriptable Objects/Database")]
public class ItemDatabaseObject : ScriptableObject,ISerializationCallbackReceiver
{
    public Item[] items;
    public Dictionary<Item, int> getID = new Dictionary<Item, int>();

    public void OnAfterDeserialize()
    {
        getID = new Dictionary<Item, int>();
        for (int i = 0; i < items.Length; i++)
        {
            getID.Add(items[i], i);
        }
    }

    public void OnBeforeSerialize()
    {
        
    }
}
