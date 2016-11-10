using UnityEngine;
using System.Collections;

public class Search : MonoBehaviour {

	//put object in the inspector
	[SerializeField] private GameObject pbulletPrefab;

	public float rate = 0;
	public float stream_delay = 0;
//	private bool allow_shot = true;
	GameObject player;
	int x = 0;


	// Use this for initialization
	void Start () {
		//tag added to player to assiocate player with the player tag
		player = GameObject.FindGameObjectWithTag ("Player");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (x > stream_delay)
			StartCoroutine (bullet ());

		x++;
	
	}


	IEnumerator bullet()
	{
		pbulletPrefab.transform.position = gameObject.transform.position;
		this.transform.LookAt (player.transform);
		//allows bullets to flow in the direction of the source object
		pbulletPrefab.transform.rotation = this.transform.rotation;
		Instantiate(pbulletPrefab);
		yield return new WaitForSeconds(rate*Time.deltaTime);
		x = 0;
	}
}    
