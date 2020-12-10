using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryslot : MonoBehaviour
{
    public Image head;
    Item item;
    public Image icon;

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.buttonicon;

        icon.enabled = true;

        
        if (newItem.Invintorytype == Item.InvintoryState.WEAPON)
        {
            //change to dofferent invintory slot;
        }
    }

    public void clearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        

    }
    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
            
        }

    }

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
