using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconUI : MonoBehaviour
{
    public Equipement iconData;
    public GameObject item;


    public void MoveMe()
    {
        //moves to player inventory
        bool waspickedup = InventoryManager.instance.Add(iconData);

        if (waspickedup)
        {
           // Destroy(gameObject);
         
        }



        //PanelPopulator playerInventory = GameObject.FindObjectOfType<PanelPopulator>();
        //transform.SetParent(playerInventory.list2transform, true);
    }
}
    // Start is called before the first frame update
   

