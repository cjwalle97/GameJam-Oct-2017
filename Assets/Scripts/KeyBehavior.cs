using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    public Key KeyConfig;
    public GameObject Holder;

	// Use this for initialization
	void Start () {
        Holder = GameObject.FindGameObjectWithTag(KeyConfig.HolderTag);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == KeyConfig.HolderTag)
        {
            Destroy(gameObject);
        }
    }
}
