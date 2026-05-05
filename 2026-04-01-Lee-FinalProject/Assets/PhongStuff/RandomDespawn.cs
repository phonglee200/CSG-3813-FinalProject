using UnityEngine;

public class RandomDespawn : MonoBehaviour
{
    public float minLife = 3f;
    public float maxLife = 8f;

    void Start()
    {
        float life = Random.Range(minLife, maxLife);
        Destroy(gameObject, life);
    }
}