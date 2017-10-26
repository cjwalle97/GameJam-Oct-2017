using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{  

    public Player player;

	void Start ()
    {
        player.health = 1;
        player.keys = 0;
        player.isDead = false;
	}

    void Update ()
    {
		if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z += 0.25f;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.z -= 0.25f;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x -= 0.25f;
            this.transform.position = position;
        }

        if(Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x += 0.25f;
            this.transform.position = position;
        }

        //  Only here if we ever expand max health to go higher than 1
        if (player.health == 0)
        {
            player.isDead = true;
        }

        if(player.isDead == true)
        {
            // Activate Game Over (UI overlay)
        }

	}
}
