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


    }
}



