using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{

    public GameObject MainCamera;
    public GameObject CreditsCamera;
    public Button StartButton;
    public Button QuitButton;
    public Button CreditsButton;
    public Button MenuButton;


    void Start()
    {
        MainCamera.SetActive(true);
        CreditsCamera.SetActive(false);
    }

    private void Update()
    {
        if(StartButton.enabled)
        {
            LoadGame();
        }

        if(MenuButton.enabled)
        {
            MainMenu();
        }

        if(CreditsButton.enabled)
        {
            CreditsMenu();
        }

        if(QuitButton.enabled)
        {
            CloseApplication();
        }
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
        Application.Quit();
    }

}
