using UnityEngine;
using System.Collections;

public class DickController : MonoBehaviour {
	private float InstantiationTimer = 1f;
	public Transform prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		InstantiationTimer -= Time.deltaTime;
		if (InstantiationTimer <= 0)
		{
			var x = Random.Range(-8, 8);
			var y = Random.Range(-3, 3);
			Instantiate(prefab, new Vector3(x,y,0), Quaternion.identity);
			InstantiationTimer = 1f;
		}
	}
}
