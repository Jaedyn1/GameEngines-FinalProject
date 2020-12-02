using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconUI : MonoBehaviour
{
    public Items iconData;
    public GameObject item;

    public void MoveMe()
    {
       
            PanelPopulator playerInventory = GameObject.FindObjectOfType<PanelPopulator>();
            item.transform.SetParent(playerInventory.GlovesSlot, true);
        }
                

        
        //PanelPopulator playerInventory = GameObject.FindObjectOfType<PanelPopulator>();
        //transform.SetParent(playerInventory.list2transform, true);
    }
    // Start is called before the first frame update
   

