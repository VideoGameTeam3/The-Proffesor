using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision involves the spawned object
        if (collision.gameObject.tag == "Police")
        {
            // Restart the game or perform any desired action
            RestartGame();
        }
        // else check if the player get the diamond and win
        else if (collision.gameObject.tag == "Diamond") {
            EndGame();
        }
    }

    void EndGame() {
        SceneManager.LoadScene("winScreen");
    }

    void RestartGame()
    {
        // Restart the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
