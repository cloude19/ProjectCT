using UnityEngine;
using System.Collections;

public class BulletS : MonoBehaviour {

	 //put object in the inspector
     [SerializeField] private GameObject pbulletPrefab;
     private GameObject pbullet;

    public float rate = 0;

    private bool allow_shot = true;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //button axis are 0 when not active and are 1 when active
        if (Input.GetAxis("Fire1") == 1 && allow_shot == true) {

            /*the prefabe object its self already has the trasform code
             * so here I just need to code it's starting position and 
             * instatiate it.
             */
             // this coroutine allow the bullet to yield for a specfic time before 
            StartCoroutine(bullet());

        }
	
	}

    IEnumerator bullet()
    {
        //bool statment allow for the rate to take effect so it won't be a yieled stream
        allow_shot = false;

        pbulletPrefab.transform.position = gameObject.transform.position;
        Instantiate(pbulletPrefab);
        yield return new WaitForSeconds(rate);

        allow_shot = true;


    }
}
