﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    NavMeshAgent nav;




	// Use this for initialization
	void Awake () 
	{
	    //Set up references
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0f) 
		{
			nav.SetDestination(player.position);


		}
		else
		{
			nav.enabled = false;
		}
	}
}
