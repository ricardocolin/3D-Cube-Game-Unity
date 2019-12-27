
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //This is reference to the Rigidbody component called rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardForce = 1f;

    // We marked this as "FixedUpdate" because we 
    //are using it to mess with physics
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("up"))
        {
            if (rb.position.y < 0.5) { 
            rb.AddForce(0, 1, 0, ForceMode.Impulse);
            }

           Debug.Log("this is the y: " + rb.position.y);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
