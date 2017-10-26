using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{

    public GameObject MainCamera;
    public GameObject CreditsCamera;


    void Start()
    {
        MainCamera.SetActive(true);
        CreditsCamera.SetActive(false);
    }

    public void CreditsMenu()
    {
        MainCamera.SetActive(false);
        CreditsCamera.SetActive(true);
    }

    public void MainMenu()
    {
        MainCamera.SetActive(true);
        CreditsCamera.SetActive(false);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void CloseApplication()
    {
        Debug.Log("User has quit apllication.");
        Application.Quit();
    }

}
