using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinotaurBehavior : MonoBehaviour
{
    public string TargetTag = "Player";
    public float Speed = 15;
    public Minotaur MinotaurConfig;
    public NavMeshAgent Agent;

    private Transform Target;

	// Use this for initialization
	void Start ()
    {
        Target = GameObject.FindGameObjectWithTag(TargetTag).transform;
	}

    private void FixedUpdate()
    {
        Agent.SetDestination(Target.position);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == TargetTag)
    //    {

    //    }
    //}
}
