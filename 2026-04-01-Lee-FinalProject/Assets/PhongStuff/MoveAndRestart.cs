using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveAndRestart : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move in negative Z direction
        transform.position += Vector3.back * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}