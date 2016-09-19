using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float horizontalMOV = 0;
    public float VerticalMOV = 0;
    public float speed = 0;
    public GameObject Player;

    private CharacterController _charController;
    private Boundary player_POS;


// Use this for initialization
void Start () {
        _charController = GetComponent<CharacterController>();

        //needed to direct boundary to the main camera version.
        player_POS = GameObject.Find("Main Camera").GetComponent<Boundary>();
    }

    // Update is called once per frame
    void Update () {



        //currently has acceleration 
        //Note: try to use character controller
        horizontalMOV = Input.GetAxisRaw("Horizontal");
        VerticalMOV = Input.GetAxisRaw("Vertical");
        
        

        Vector3 movement = new Vector3(horizontalMOV* speed, VerticalMOV* speed, 0.0f);
        
        movement = Vector3.ClampMagnitude(movement, speed);
        movement *= Time.smoothDeltaTime;
        _charController.Move(movement);


        //bounds the player character to a 11x5 retangle based off world coordinates
        if (Player.transform.position.x <= -11f)
        {
            Player.transform.position = new Vector3(-11,Player.transform.position.y,Player.transform.position.z);
        }
        else if (Player.transform.position.x > 11f)
        {
            Player.transform.position = new Vector3(11, Player.transform.position.y, Player.transform.position.z);
        }
        if (Player.transform.position.y >= 5)
        {
            Player.transform.position = new Vector3(Player.transform.position.x, 5, Player.transform.position.z);
        }
        else if (Player.transform.position.y <= -5)
        {
            Player.transform.position = new Vector3(Player.transform.position.x, -5, Player.transform.position.z);
        }





        //   transform.position += Vector3.ClampMagnitude(movement, speed) * Time.deltaTime;

    }
}
