using UnityEngine;

public class SpawnFromZone : MonoBehaviour
{
    public GameObject prefab;
    public float spawnInterval = 2f;
    public float spawnCooldown = 2f;

    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time + spawnCooldown;
        }
    }

    void Spawn()
    {
        BoxCollider zone = GetComponent<BoxCollider>();

        Vector3 center = transform.position + zone.center;
        Vector3 size = zone.size;

        Vector3 randomPos = new Vector3(
            Random.Range(-size.x / 2f, size.x / 2f),
            Random.Range(-size.y / 2f, size.y / 2f),
            Random.Range(-size.z / 2f, size.z / 2f)
        );

        Vector3 spawnPos = center + transform.TransformVector(randomPos);

        Instantiate(prefab, spawnPos, Quaternion.identity);
    }
}