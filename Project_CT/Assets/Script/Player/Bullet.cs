using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    /*Serialized allows objects to still be viewed in the inspector
     * even know it private
    */
   // [SerializeField] private GameObject pbulletPrefab;
   // private GameObject pbullet;

    public float speed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        /*test output
        Debug.Log(Input.GetAxis("Fire1"));
        */
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



