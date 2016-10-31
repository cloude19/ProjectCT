using UnityEngine;
using System.Collections;

public class Straight : MonoBehaviour {

	public float speed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(0, 0, speed * Time.deltaTime);

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
