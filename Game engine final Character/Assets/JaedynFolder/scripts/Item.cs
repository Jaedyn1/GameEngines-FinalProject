﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]


[CreateAssetMenu(menuName ="Inventory/NewEquipement",fileName ="New Equipement",order =1)]
public class Item : ScriptableObject
{
    public enum InvintoryState
    {
        GLOVES,
        HELMET,
        BOOTS,
        CHEST,
        WEAPON,

    }

    public int id;
    public string IName;


    public InvintoryState Invintorytype;
    public Sprite buttonicon;
    public Transform inventoryTransform;
    public Transform SlotTransform;
    public bool IsDefult = false;

    
    public virtual void Use()
    {

        Debug.Log("using" + IName);
        
    }
    public void removeFromInventory()
    {
        InventoryManager.instance.Remove(this);


    }

    
   
    
    public Sprite Buttonicon
    {
        get
        {
            return buttonicon;
        }
    }
}
