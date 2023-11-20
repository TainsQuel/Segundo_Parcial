using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void BasicScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
