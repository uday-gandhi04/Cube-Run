using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstracle")
        {
            FindObjectOfType<AudioManager>().Play("Crash");
            movement.enabled= false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

