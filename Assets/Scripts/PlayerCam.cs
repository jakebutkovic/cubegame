
using UnityEngine;

public class PlayerCam : MonoBehaviour{

    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update(){
        transform.position = player.position + offset; //the camera's(game obj called main camera) position is set equal to the players position
    }
}
