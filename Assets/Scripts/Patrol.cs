using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : EnemyBaseFSM
{
    GameObject[] waypoints;
    int currentWP;
    float WPradius = 1;
    private int random;

    void Awake()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        random = Random.Range(0, waypoints.Length);
        currentWP = random;
        agent.speed = 2.0f;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        if (Vector3.Distance(waypoints[currentWP].transform.position, Enemy.transform.position) < WPradius)
        {
            random = Random.Range(0, waypoints.Length);
            currentWP = random;
            if (currentWP >= waypoints.Length)
            {
                currentWP = 0;
            }
        }

        agent.SetDestination(waypoints[currentWP].transform.position);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
