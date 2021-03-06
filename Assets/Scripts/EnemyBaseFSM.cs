﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseFSM : StateMachineBehaviour
{
    public  GameObject Enemy;
    public GameObject Player;
    public UnityEngine.AI.NavMeshAgent agent;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Enemy = animator.gameObject;
        Player = Enemy.GetComponent<EnemyAI>().GetPlayer();
        agent = Enemy.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
}
