using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMoveForwardRestart : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move forward continuously
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}