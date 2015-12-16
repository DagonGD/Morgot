using UnityEngine;
using System.Collections;

public class BanController : MonoBehaviour {
	public Transform ban;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		newPos.z = -0.1f;
		ban.position = newPos;
	}

	void OnCollisionStay2D(Collision2D coll) {
		if (Input.GetMouseButton (0)) {
			Destroy(coll.gameObject);
		}
		
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy")
			coll.gameObject.SendMessage("ApplyDamage", 10);
	}
}
