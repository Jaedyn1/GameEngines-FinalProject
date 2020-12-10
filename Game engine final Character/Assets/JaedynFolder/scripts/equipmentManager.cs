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

    public Image
        GLOVES,
    HELMET,
    BOOTS,
    CHEST,
    WEAPON;
    public Text CHESTtext;
    public Text WEAPONtext;
    public Text BOOTStext;
    public Text HELMETtext;
    public Text GLOVEStext;



    Equipement[] currentEquipment;


    public delegate void OnEquipnentChanged(Equipement newItem, Equipement oldItem);
    public OnEquipnentChanged onEquipnentChanged;

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

        if (onEquipnentChanged != null)
        {
            onEquipnentChanged.Invoke(newItem, olditem);
            
        }


        if (newItem.equipslot == EquipmentSlot.HELMET)
        {
            HELMET.sprite = newItem.Buttonicon;
            HELMETtext.text = newItem.IName;
        }
       
        if (newItem.equipslot == EquipmentSlot.CHEST)
        {
            CHEST.sprite = newItem.Buttonicon;
            CHESTtext.text = newItem.IName;

        }
        if (newItem.equipslot == EquipmentSlot.GLOVES)
        {
            GLOVES.sprite = newItem.Buttonicon;
            GLOVEStext.text = newItem.IName;
        }
        if (newItem.equipslot == EquipmentSlot.WEAPON)
        {
            WEAPON.sprite = newItem.Buttonicon;
            WEAPONtext.text = newItem.IName;
        }
        if (newItem.equipslot == EquipmentSlot.BOOTS)
        {
            BOOTS.sprite = newItem.Buttonicon;
            BOOTStext.text = newItem.IName;

        }


    }
    public void Unequip(int slotIndex)
    {
        if (currentEquipment[slotIndex] != null)
        {
            
            Equipement olditem = currentEquipment[slotIndex];
            inventory.Add(olditem);
            
            currentEquipment[slotIndex] = null;

            if (onEquipnentChanged != null)
            {
                onEquipnentChanged.Invoke(null, olditem);
            }

        }

    }
    public void UnEquipAll()
    {

        GLOVES.sprite = null;
        CHEST.sprite = null;
        HELMET.sprite = null;
        BOOTS.sprite = null;
        WEAPON.sprite = null;
        CHESTtext.text = null;
        HELMETtext.text = null;
        GLOVEStext.text = null;
        WEAPONtext.text = null;
        BOOTStext.text = null;

        for (int i = 0; i < currentEquipment.Length; i++)
        {
            Unequip(i);
        }
    }

    
    public void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            UnEquipAll();

        }
        
    }
}


