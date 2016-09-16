using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float horizontalMOV = 0;
    public float VerticalMOV = 0;
    public float speed = 0;

    private CharacterController _charController;



    // Use this for initialization
    void Start () {
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update () {

        //currently has acceleration 
        //Note: try to use character controller
        horizontalMOV = Input.GetAxisRaw("Horizontal");
        VerticalMOV = Input.GetAxisRaw("Vertical");
        


        Vector3 movement = new Vector3(horizontalMOV* speed, VerticalMOV* speed, 0.0f);
        
        movement = Vector3.ClampMagnitude(movement, speed);
        movement *= Time.deltaTime;
        _charController.Move(movement);



        //   transform.position += Vector3.ClampMagnitude(movement, speed) * Time.deltaTime;

    }
}
