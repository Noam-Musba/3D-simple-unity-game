using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager game_manager;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().enabled = false;
            game_manager.CompleteLevel();
        }
        
    }
}
