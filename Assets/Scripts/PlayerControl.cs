using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{



	void Start ()
    {

	}

    void Update ()
    {

        this.transform.position = new Vector3(this.transform.position.x, 1.5f, this.transform.position.z);
        this.transform.rotation = new Quaternion(0, 0, 0, 0);

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

	}
}
