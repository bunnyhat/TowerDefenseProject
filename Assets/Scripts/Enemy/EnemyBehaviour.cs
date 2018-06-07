using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour {
	public EnemyType enemy;
	
	public string enemyName;
	public float currentHP, maxHP;
	public float attackSpeed;
	public float damage;
	
	public NavMeshAgent agent;
	public Transform towerLocation;

	void Awake() {
		enemyName = enemy.name;
		currentHP = enemy.currentHP;
		maxHP = enemy.maxHP;
		agent.speed = enemy.walkSpeed;
		attackSpeed = enemy.attackSpeed;
		damage = enemy.damage;

		agent.SetDestination(towerLocation.position);
	}
}
