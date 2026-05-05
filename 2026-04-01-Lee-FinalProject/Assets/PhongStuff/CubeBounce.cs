using UnityEngine;

public class CubeBounce : MonoBehaviour
{
    public float speed = 3f;

    private Vector3 direction;

    void Awake()
    {
        direction = Random.value < 0.5f ? Vector3.left : Vector3.right;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction = -direction;
        }
    }
}