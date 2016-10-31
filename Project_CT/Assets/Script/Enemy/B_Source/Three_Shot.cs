using UnityEngine;
using System.Collections;

public class Three_Shot : MonoBehaviour {

	//put object in the inspector
	[SerializeField] private GameObject pbulletPrefab;

	public float rate = 0;
	public float stream_delay = 0;
	private bool allow_shot = true;
	int x = 0;

	// Use this for initialization
	void Start () {
	
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
		Instantiate(pbulletPrefab);
		//allows bullets to flow in the direction of the source object
		pbulletPrefab.transform.rotation = this.transform.rotation;
		yield return new WaitForSeconds(rate);
		x = 0;
	}
}
