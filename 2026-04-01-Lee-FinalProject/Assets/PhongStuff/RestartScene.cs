using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class RestartScene : MonoBehaviour
{
    void Update()
    {
        // Check if the 'R' key is pressed down this frame
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reload the currently active scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}