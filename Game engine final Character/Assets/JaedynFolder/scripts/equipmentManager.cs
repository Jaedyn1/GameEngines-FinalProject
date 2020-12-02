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

    Item[] currentEquipment;
    public  void Start()
    {

        int numslots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new Item[numslots];

    }

    public void Equip(Equipement newItem)
    {
        int slotindex = (int)newItem.equipslot;
        currentEquipment[slotindex] = newItem;

    }
}


