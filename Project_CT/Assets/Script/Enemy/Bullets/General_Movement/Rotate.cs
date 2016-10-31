using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float speed = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, speed * Time.deltaTime);
		//make render object invisiable without deleteing the object
		GetComponent<Renderer> ().enabled = false;
	}
}
