using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public GameObject MenuPausa;

    void Start()
    {

    }
    void Update()
    {
       if (Input.GetKeyUp(KeyCode.Escape))
        {
            MenuPausa.SetActive(true);

            Time.timeScale = 0;
        }
    }

    public void Despausar()
    {
        MenuPausa.SetActive(false);

        Time.timeScale = 1.0f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);

        Time.timeScale = 1.0f;
    }

    public void Salir()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
