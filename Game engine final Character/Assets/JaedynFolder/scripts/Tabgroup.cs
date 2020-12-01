using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabgroup : MonoBehaviour
{
    public List<Tabbuttons> tabbutton;

    public void Subscribe(Tabbuttons button)
    {
        if (tabbutton == null)
        {
            tabbutton = new List<Tabbuttons>();
        }
       
    }
    
}
