using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equipmentManager : MonoBehaviour
{
    #region Singeltion
    public static equipmentManager instance;
    public  void Awake()
    {
        instance = this;
    }

    #endregion

    Equipement[] currentEquipment;

    InventoryManager inventory;

    public  void Start()
    {
        inventory = InventoryManager.instance;

        int numslots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new Equipement[numslots];

    }

    public void Equip(Equipement newItem)
    {
        Equipement olditem = null;
        int slotindex = (int)newItem.equipslot;
        if (currentEquipment[slotindex] != null)
        {
            olditem = currentEquipment[slotindex];
            inventory.Add(olditem);
        }
        currentEquipment[slotindex] = newItem;

    }
}


