using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapButtons : MonoBehaviour
{

    public GameObject item;

    public void MoveMe()
    {
        PanelPopulator playerInventory = GameObject.FindObjectOfType<PanelPopulator>();
        item.transform.SetParent(playerInventory.headslot, true);
    }
}
