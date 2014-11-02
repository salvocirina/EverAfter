using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(enemy.tag.ToString());
	}

	void onCollisionEnter(GameObject enemy){

		Debug.Log (enemy.tag.ToString);
	}
}
