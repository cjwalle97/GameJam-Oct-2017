using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public Player player;
    public MenuOptions menuInstance;

    public int playerHealth;
    public int playerKeys;
    public bool playerIsDead;
    
    void Start ()
    {
        player.health = 1;
        player.keys = 0;
        player.isDead = false;
    }
	
	void Update ()
    {

        playerHealth = player.health;
        playerKeys = player.keys;
        playerIsDead = player.isDead;

        //  Only here if we ever expand max health to go higher than 1
        if (player.health == 0)
        {
            player.isDead = true;
        }

        if (player.isDead == true)
        {
            menuInstance.PlayerCameraCanvas.SetActive(true);
            Destroy(player);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            player.keys++;
            Destroy(other.gameObject);
            Debug.Log("Player touched key");
        }

        if (other.tag == "Enemy")
        {
            player.health--;
            Debug.Log("Player was hit by enemy.");
        }
    }
}
