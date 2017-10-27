using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{

    public GameObject MainCamera;
    public GameObject CreditsCamera;
    public GameObject PlayerCameraCanvas;

    private DisplayTimer timerA;
    private SpawnMinotaur timerB;
    private DoorBehavior timerC;

    void Start()
    {
        MainCamera.SetActive(true);
        CreditsCamera.SetActive(false);
        PlayerCameraCanvas.SetActive(false);
        timerA.timer = 0;
        timerB.timer = 0;
        timerC.timer = 0;
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

    public void SwitchToMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void DisplayGameOver()
    {
        PlayerCameraCanvas.SetActive(true);
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
