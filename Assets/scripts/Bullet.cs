using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
//	public Rigidbody2D rigid;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnBecameInvisible() {  
		Debug.Log("Destroying bullet");
		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log(coll.gameObject.tag);
		if (coll.gameObject.tag == "Enemy") {
		  Destroy(gameObject);
		}
	}
}
