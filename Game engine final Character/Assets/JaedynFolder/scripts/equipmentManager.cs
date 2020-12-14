using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public Image
    GLOVESI,
    HELMETI,
    BOOTSI,
    CHESTI,
    WEAPONI;
    public Text
        GLOVEST,
    HELMETT,
    BOOTST,
    CHESTT,
    WEAPONT;
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
        if (newItem.equipslot == EquipmentSlot.HELMET)
        {
            HELMETI.sprite = newItem.buttonicon;
            HELMETT.text = newItem.IName;
        }
        if (newItem.equipslot == EquipmentSlot.CHEST)
        {
            CHESTI.sprite = newItem.buttonicon;
            CHESTT.text = newItem.IName;
        }
        if (newItem.equipslot == EquipmentSlot.GLOVES)
        {
            GLOVESI.sprite = newItem.buttonicon;
            GLOVEST.text = newItem.IName;
        }
        if (newItem.equipslot == EquipmentSlot.WEAPON)
        {
            WEAPONI.sprite = newItem.buttonicon;
            WEAPONT.text = newItem.IName;
        }
        if (newItem.equipslot == EquipmentSlot.BOOTS)
        {
            BOOTSI.sprite = newItem.buttonicon;
            BOOTST.text = newItem.IName;
        }
    }
    public void unEquip(int slotIndex)
    {
        if (currentEquipment[slotIndex] != null)
        {
            Equipement olditem = currentEquipment[slotIndex];
            inventory.Add(olditem);
            currentEquipment[slotIndex] = null;

        }


    }
    public void unequipAll()
    {
        GLOVESI.sprite = null;
        HELMETI.sprite = null;
        CHESTI.sprite = null;
        WEAPONI.sprite = null;
        BOOTSI.sprite = null;
        GLOVEST.text = null;
        HELMETT.text = null;
        CHESTT.text = null;
        WEAPONT.text = null;
        BOOTST.text = null;


        for (int i = 0; i < currentEquipment.Length; i++)
        {
            unEquip(i);
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            unequipAll();


        }
    }
}


