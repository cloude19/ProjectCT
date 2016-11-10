using UnityEngine;
using System.Collections;

public class Shield_Astetic : MonoBehaviour {


	public float speed = 0f;
	public Color32 Bullet_Color;
	public byte alpha = 0;

	bool switching = true;
	bool Resize = true;
	bool switched = false;
	string Char = "";



	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (0, 0, speed * Time.deltaTime);

		//Blue
		if (Input.GetKey ("k") == true || Char == "k") {
			Char = "k";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (75, 151, 255, alpha);
				Bullet_Color = new Color32 (75, 151, 255, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				 if (gameObject.transform.localScale.x >= 1.07f) {
					 gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					 switching = false;
						}
					}
			}

		//Dark_Blue
		if (Input.GetKey ("x") == true || Char == "x") {
			Char = "x";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (19, 0, 255, alpha);
				Bullet_Color = new Color32 (19, 0, 255, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Green
		if (Input.GetKey ("c") == true || Char == "c") {
			Char = "c";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (0, 165, 15, alpha);
				Bullet_Color = new Color32 (0, 165, 15, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Green_Blue
		if (Input.GetKey ("v") == true || Char == "v") {
			Char = "v";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (0, 255, 149, alpha);
				Bullet_Color = new Color32 (0, 255, 149, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Hot_Pink
		if (Input.GetKey ("z") == true || Char == "z") {
			Char = "z";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (255, 139, 247, alpha);
				Bullet_Color = new Color32 (255, 139, 247, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Light_Green
		if (Input.GetKey ("b") == true || Char == "b") {
			Char = "b";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (138, 255, 116, alpha);
				Bullet_Color = new Color32 (138, 255, 116, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Purple
		if (Input.GetKey ("n") == true || Char == "n") {
			Char = "n";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (178, 0, 255, alpha);
				Bullet_Color = new Color32 (178, 0, 255, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Red
		if (Input.GetKey ("m") == true || Char == "m") {
			Char = "m";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (219, 29, 29, alpha);
				Bullet_Color = new Color32 (219, 29, 29, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Red_Orange
		if (Input.GetKey ("f") == true || Char == "f") {
			Char = "f";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (255, 125, 1, alpha);
				Bullet_Color = new Color32 (255, 125, 1, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Yellow
		if (Input.GetKey ("g") == true || Char == "g") {
			Char = "g";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (255, 248, 0, alpha);
				Bullet_Color = new Color32 (255, 248, 0, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Yellow_Orange
		if (Input.GetKey ("h") == true || Char == "h") {
			Char = "h";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (216, 174, 0, alpha);
				Bullet_Color = new Color32 (216, 174, 0, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}

		//Orange
		if (Input.GetKey ("j") == true || Char == "j"){
			Char = "j";
			if (switching == true && Resize == true) {
				gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x <= 0) {
					Resize = false;
				}
			}
			if (switching == true && Resize == false) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (150, 122, 0, alpha);
				Bullet_Color = new Color32 (150, 122, 0, alpha);
				gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
				if (gameObject.transform.localScale.x >= 1.07f) {
					gameObject.transform.localScale = new Vector3 (1.07f, 1.07f, 1.07f);
					switching = false;
				}
			}
		}



		//switch to true
		if (Input.GetKey ("k") == true || Input.GetKey ("j") == true || Input.GetKey ("x") == true || Input.GetKey ("c") == true || Input.GetKey ("v") == true || Input.GetKey ("b") == true || Input.GetKey ("n") == true || Input.GetKey ("m") == true || Input.GetKey ("f") == true || Input.GetKey ("g") == true || Input.GetKey ("h") == true || Input.GetKey ("z") == true){
			switching = true;
			Resize = true;
		}
	
	}
}
