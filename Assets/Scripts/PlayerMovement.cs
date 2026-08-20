using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // use FixedUpdate for physics-based movement
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // if (Input.GetKey(KeyCode.W))
        // {
        //     // Time.deltaTime is the interval in seconds from the last frame to the current one
        //     rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        // }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
