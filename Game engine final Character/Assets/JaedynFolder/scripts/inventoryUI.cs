using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryUI : MonoBehaviour
{
    InventoryManager inventory;
    public Transform itemsparent1;


    inventoryslot[] slots1;
   
    // Start is called before the first frame update
    void Start()
    {
        inventory = InventoryManager.instance;
        inventory.onitemchangeCallBack += updateUI;

        
        
    }

    public void Update()
    {
        slots1 = itemsparent1.GetComponentsInChildren<inventoryslot>();
    }
    void updateUI()
    {
        //invintory head
        for (int a = 0; a < slots1.Length; a++)
        {
           
                    if (a < inventory.items.Count)
                    {
                        slots1[a].AddItem(inventory.items[a]);
                    }
                    else
                    {
                        slots1[a].clearSlot();
                    }
                
            
        }


       
        Debug.Log("updating UI");
    }

}//foreach (Item singleitem in inventory.items)
   //         {
     //           if (singleitem.Invintorytype == Item.InvintoryState.Head)
       //         {
