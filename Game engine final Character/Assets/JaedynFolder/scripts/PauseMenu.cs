using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool ispaused;
    public GameObject Pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            if (ispaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    
    }
    public void ResumeGame()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;

    }
}
