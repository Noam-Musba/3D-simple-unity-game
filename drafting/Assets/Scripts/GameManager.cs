using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool game_has_ended = false;
    public float restart_delay = 2f;
    public GameObject complete_level_ui;

    public void CompleteLevel()
    {
        complete_level_ui.SetActive(true);
        //Debug.Log("woohoo");
    }

    public void EndGame()
    {
        if (!game_has_ended)
        {
            game_has_ended = true;
            Debug.Log("Game Over");
            Invoke("Restart", restart_delay);
            //Restart();
        }
        
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
