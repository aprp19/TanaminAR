using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject selectionMenu;

    public void GotoStart()
    {
        startMenu.SetActive(true);
        selectionMenu.SetActive(false);
    }
    public void GoToSelection()
    {
        startMenu.SetActive(false);
        selectionMenu.SetActive(true);
    }
    public void GoToPanganScene()
    {
        SceneManager.LoadScene(1);
    }
    
}
