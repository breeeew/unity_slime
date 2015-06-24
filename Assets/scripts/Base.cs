using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour {
	public int health;
	public int power;
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		health = 100;
		power = 1;
		InvokeRepeating("IncreasePower", 0, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			Attack();
		}

	}

	void Attack() {
		if (power == 0) return;
		enemy.SendMessage ("Attack", (1));
		power--;
	}
	
	void IncreasePower () {
		power += 1;

		if (power < 10)
			transform.localScale = new Vector3 (1.0f, 1.0f, 0); 

		switch (power) {
		case 10:
			transform.localScale = new Vector3(1.2f, 1.2f, 0);
			break;
		case 20:
			transform.localScale = new Vector3(1.4f, 1.4f, 0);
			break;
		case 30:
			transform.localScale = new Vector3(1.6f, 1.6f, 0);
			CancelInvoke("IncreasePower");
			break;
		}
	}
}
