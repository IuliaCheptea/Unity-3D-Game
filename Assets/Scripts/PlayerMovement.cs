using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidbody;

    public float forwardForce = 500f;
    public float sidewaysForce = 300f;
 
    // Time.deltaTime = the completion time in seconds since the last frame
    void FixedUpdate()
    {
        // Add a forward force
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
