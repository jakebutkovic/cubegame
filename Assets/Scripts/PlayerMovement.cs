
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Rigidbody Rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    
    // Start is called before the first frame update
   /* void Start(){
        // Rb.useGravity = false ; // this turns rigidbody to false on an object
        Rb.AddForce(0, 200, 500);
    }
   */
    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time.deltaTime is used to calculate the amount of secs since the pc drew the last frame.

        if (Input.GetKey("d")) { // If the player presses the "D" key  
            //Add a force to the right
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {

            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
