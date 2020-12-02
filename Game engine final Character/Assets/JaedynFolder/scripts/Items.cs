using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Itemtype
{
    GLOVES,
    HELMET,
    BOOTS,
    CHEST,
    WEAPON,

}
[System.Serializable]

[CreateAssetMenu(menuName ="Inventory/NewEquipement",fileName ="New Equipement",order =1)]
public class Items : ScriptableObject
{
   
    public int id;
    public string IName;
    [SerializeField]
    public Itemtype Catigory;
    public Sprite buttonicon;
    public Transform inventoryTransform;
    public Transform SlotTransform;

    public Itemtype katigory
    {
        get
        {
            return Catigory;
        }
    }
    public Sprite Buttonicon
    {
        get
        {
            return buttonicon;
        }
    }
}
