using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public GameObject playerCam;

    private Vector3 lastPos;
    private Quaternion lastTurn;
    public float speed = 5f;
    public Vector3 move;
    Rigidbody rb;

    void Start ()
    {
        lastPos = this.transform.position;
        lastTurn = new Quaternion(0, 0, 0, 0);
        rb = GetComponent<Rigidbody>();
	}

    void Update ()
    {
        this.transform.rotation = lastTurn;
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        move = new Vector3(h, 0, v);
        var velocity = new Vector3(move.x, 0, move.z);
        rb.velocity = velocity * speed;
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Vector3 position = this.transform.position;
        //    position.z += 0.25f;
        //    this.transform.position = position;
        //    lastPos = this.transform.position;
        //    lastTurn = new Quaternion(0, 0, 0, 0);
        //    //playerCam.transform.position += new Vector3(0, 0, 0.25f);
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    Vector3 position = this.transform.position;
        //    position.z -= 0.25f;
        //    this.transform.position = position;
        //    lastPos = this.transform.position;
        //    lastTurn = new Quaternion(0, 1, 0, 0);
        //  //  playerCam.transform.position -= new Vector3(0, 0, 0.25f);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x -= 0.30f;
        //    this.transform.position = position;
        //    lastPos = this.transform.position;
        //    lastTurn = new Quaternion(0, 1, 0, -1);
        //   // playerCam.transform.position -= new Vector3(0.30f, 0, 0);

        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x += 0.30f;
        //    this.transform.position = position;
        //    lastPos = this.transform.position;
        //    lastTurn = new Quaternion(0, 1, 0, 1);
        //   // playerCam.transform.position += new Vector3(0.30f, 0, 0);

        //}

        //if (!Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.W))
        //{
        //    this.transform.position = lastPos;
            
        //}

	}
}
