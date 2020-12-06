using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public Transform characterposition;





    public void resetPosition()
    {
        characterposition.transform.position = new Vector3(0, 0, 0);
    }
}
