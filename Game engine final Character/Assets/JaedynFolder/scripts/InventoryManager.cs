using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    #region Singeleton
    public static InventoryManager instance;

  
    public delegate void Onitemchange();
    public Onitemchange onitemchangeCallBack;
    public int Space = 5;
    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More then one instance of inventory found! ");
            return;
        }
        instance = this;
    }
    #endregion

    public bool Add(Equipement item)
    {
        if (!item.IsDefult)
        {
            if (items.Count > Space)
            {
                Debug.Log("Is not enough space");
                return false;
            }
            items.Add(item);
            if (onitemchangeCallBack != null)
            {
                onitemchangeCallBack.Invoke();
            }
        }

        return true;

    }
    public void Remove(Item item)
    {

        items.Remove(item);
        if (onitemchangeCallBack != null)
        {
            onitemchangeCallBack.Invoke();
        }
    }
    public void changecatagory()
    {



    } 

}
