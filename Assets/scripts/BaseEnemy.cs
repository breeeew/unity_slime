using UnityEngine;
using System.Collections;

public class BaseEnemy : MonoBehaviour {
	public int health;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Debug.Log("Im Die!");
		}
	}

	void Attack(int decr_health){
		health = health - decr_health;
		transform.localScale = new Vector3(health / 10, health / 10, 1);
	}
}
