using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinotaurBehavior : MonoBehaviour
{
    public string TargetTag = "Player";
    public Minotaur MinotaurConfig;
    public NavMeshAgent Agent;

    public List<GameObject> WanderPoints;

    private int TargetIndex;
    private Transform Target;
    private Transform PlayerTarget;

    // Use this for initialization
    void Start()
    {
        PlayerTarget = GameObject.FindGameObjectWithTag("Player").transform;
        TargetIndex = 0;
        Target = WanderPoints[TargetIndex].transform;
        Agent.SetDestination(Target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, PlayerTarget.position) > 50)
        {
            if (Vector3.Distance(transform.position, Target.position) < 0.1f)
            {
                TargetIndex++;
                if (TargetIndex >= WanderPoints.Count)
                {
                    TargetIndex = 0;
                }

                Target = WanderPoints[TargetIndex].transform;
            }
            Agent.SetDestination(Target.position);
        }
        else
        {
            Agent.SetDestination(PlayerTarget.position);
        }
        
    }

}
