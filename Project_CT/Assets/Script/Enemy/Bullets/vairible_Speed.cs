using UnityEngine;
using System.Collections;

public class vairible_Speed : MonoBehaviour {

	float speed;

	// Use this for initialization
	void Start () {
		 speed = Random.Range(1f,6f);

	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(0, 0, speed * Time.deltaTime);
		//gameObject.GetComponent<Renderer> ().material.color = new Color (1, 2, 3, 0);
		/*Destroy bullet object if it's out side of these boundaries [can be universal]
         * worst case is 12 bullet object at once at current speed
        */
		if (gameObject.transform.position.x <= -15f)
		{
			Destroy(gameObject);
		}
		else if (gameObject.transform.position.x > 15f)
		{
			Destroy(gameObject);
		}
		if (gameObject.transform.position.y >= 10)
		{
			Destroy(gameObject);
		}
		else if (gameObject.transform.position.y <= -10)
		{
			Destroy(gameObject);
		}
	}
	
	}
