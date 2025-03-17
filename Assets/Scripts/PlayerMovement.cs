using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D)) 
        {
            FindObjectOfType<AudioManager>().Play("Whoosh");
            rb.AddForce(sidewaysForce* Time.deltaTime,0, 0,ForceMode.VelocityChange) ;
        }
        if (Input.GetKey(KeyCode.A))
        {
            FindObjectOfType<AudioManager>().Play("Whoosh");
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0,  10000* Time.deltaTime, 0);
        }*/

        if(rb.position.y < -1f)
        {
            FindObjectOfType<AudioManager>().Play("Fall");
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
