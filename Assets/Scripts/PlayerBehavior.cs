using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public Player player;
    public GameObject failureMenu;
    public int playerHealth;
    public int playerKeys;
    
    void Start ()
    {
        failureMenu.SetActive(false);
        player.health = 1;
        player.keys = 0;
    }
	
	void Update ()
    {

        playerHealth = player.health;
        playerKeys = player.keys;

        //  Only here if we ever expand max health to go higher than 1
        if (player.health <= 0)
        {
            failureMenu.SetActive(true);
            Destroy(gameObject);
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
