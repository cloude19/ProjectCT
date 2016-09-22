using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

    Camera main_camera;
    public Transform player;
    public Vector3 screenPos;

    private double fps = 0;

    // Use this for initialization
    void Start () {
        main_camera = GetComponent<Camera>();


    }

    // Update is called once per frame
    void Update () {

        //get player postion compared to camera
        screenPos = main_camera.WorldToScreenPoint(player.position);
        //   Debug.Log("player X postion is" + screenPos.x + "Player Y postion is" + screenPos.y);
        fps = 1.0 / Time.deltaTime;
      //  Debug.Log("Current fps: " + fps);

    }
}
