using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorBehavior : MonoBehaviour
{
    public GameObject victoryCanvas;
    public Door DoorConfig;
    public GameObject KeyHolder;
    public Player player;
    public int KeyScore;
    public Text timeText;
    public float timer;

    public bool isOpen;
    // Use this for initialization
    void Start()
    {
        KeyHolder = GameObject.FindGameObjectWithTag("Player");
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        KeyScore = player.keys;
        if (KeyScore == DoorConfig.KeysNeeded)
        {
            Open();
        }
        timer = Time.time;
    }

    public void Open()
    {
        //Open Animation goes here
        Debug.Log("Player has enough Keys to win.");
        isOpen = true;
    }

    public void Victory()
    {
        //displays the win message
        KeyHolder.SetActive(false);
        victoryCanvas.SetActive(true);
        timeText.text = "Completion Time: " + timer.ToString();
        Debug.Log("Player has won the game!");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isOpen == false)
            {
                Debug.Log("Not enough Keys");
            }

            if (isOpen == true)
            {
                Victory();
            }
        }
    }
}
