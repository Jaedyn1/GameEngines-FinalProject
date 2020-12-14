using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour
{
    public bool paused; 
    public GameObject pausedmenu;
    // Start is called before the first frame update
    void Start()
    {
        pausedmenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pausedmenu()
    {
        pausedmenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;

    }
    public void Resumemenu()
    {
        pausedmenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)||Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resumemenu();
            }
            else
            {
                Pausedmenu();

            }

        }
    }
}
