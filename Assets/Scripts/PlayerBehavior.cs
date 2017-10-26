using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public Player player;
    public MenuOptions menuInstance;

    private int playerHealth;
    private int playerKeys;
    private bool playerIsDead;

    void Start ()
    {
        player.health = 1;
        player.keys = 0;
        player.isDead = false;
    }
	
	void Update ()
    {
        //  Only here if we ever expand max health to go higher than 1
        if (playerHealth == 0)
        {
            playerIsDead = true;
        }

        if (playerIsDead == true)
        {
            menuInstance.PlayerCameraCanvas.SetActive(true);
            Destroy(player);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            playerKeys++;
            Destroy(gameObject);
            Debug.Log("Player touched key");
        }

        if (other.tag == "Enemy")
        {
            playerHealth--;
            Debug.Log("Player was hit by enemy.");
        }
    }
}
