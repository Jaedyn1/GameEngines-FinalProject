using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Equipement",menuName ="Inventory/equipement" )]
public class Equipement : Item
{
    
    public EquipmentSlot equipslot;
    public override void Use()
    {

        base.Use();

        equipmentManager.instance.Equip(this);
        removeFromInventory();
       // if (Equipement.InvintoryState ==)

    }
}
public enum EquipmentSlot {
    GLOVES,
    HELMET,
    BOOTS,
    CHEST,
    WEAPON,
}
