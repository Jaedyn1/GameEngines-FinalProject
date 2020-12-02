using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    public GameObject character;
   
    bool PlayerEnter;
    [SerializeField]
    public string sceneName;
    public GameObject TipsTitle;
    
    void Start()
    {
        
        if (character = null)
        {
            Debug.Log("didn't find the player");
          character =  GameObject.Find("Player");
        }
    }
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
                TipsTitle.SetActive(false);
                character.transform.position = new Vector3(0, 0, 0);

                SwitchToScene();
            }
        }
    }



}
