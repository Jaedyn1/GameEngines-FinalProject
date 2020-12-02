using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryUI : MonoBehaviour
{
    InventoryManager inventory;
    public Transform itemsparent;

    inventoryslot[] slots;
    // Start is called before the first frame update
    void Start()
    {
        inventory = InventoryManager.instance;
        inventory.onitemchangeCallBack += updateUI;


        slots = itemsparent.GetComponentsInChildren<inventoryslot>();
    }

    void updateUI()
    {

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {

                slots[i].clearSlot();
            }
        }
        Debug.Log("updating UI");
    }
   
}
