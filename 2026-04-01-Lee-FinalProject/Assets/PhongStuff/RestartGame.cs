using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public KeyCode restartKey = KeyCode.P;

    void Update()
    {
        if (Input.GetKeyDown(restartKey))
        {
            Restart();
        }
    }

    void Restart()
    {
        // Reload current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}