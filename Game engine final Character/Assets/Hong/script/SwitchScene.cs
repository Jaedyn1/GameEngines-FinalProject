using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
   
   
    bool PlayerEnter;
    [SerializeField]
    public string sceneName;
    public GameObject TipsTitle;
    
    public void SwitchToScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    private void OnTriggerExit(Collider otherObject)
    {

        if (otherObject.gameObject.CompareTag("CheckPoint")  )
        {
            Debug.Log("exit");
            TipsTitle.SetActive(false);
            PlayerEnter = false;
            
           
        }
        
    }

    private void OnTriggerStay(Collider otherObject)
    {
      
        if (otherObject.gameObject.CompareTag("CheckPoint")||PlayerEnter == false)
        {
            Debug.Log("attach the place you can transfer");
            TipsTitle.SetActive(true);
            PlayerEnter = true;
            if ( Input.GetButtonDown("Jump"))
            {
                SwitchToScene();
                TipsTitle.SetActive(false);
          
               
            }
        }
    }



}
