using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            //movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
        
    }
}
