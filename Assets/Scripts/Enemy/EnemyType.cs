using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Enemy")]
public class EnemyType : ScriptableObject {
	public new string name;
	public GameObject model;
	public float currentHP, maxHP;
	public float walkSpeed;
	public float attackSpeed;
	public float damage;
}
