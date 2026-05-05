using UnityEngine;

public class SpawnCubeInFront : MonoBehaviour
{
    public GameObject cubePrefab;

    public float spawnDistance = 3f;
    public KeyCode spawnKey = KeyCode.E;

    public float spawnCooldown = 3f;
    private float nextSpawnTime = 0f;

    void Update()
    {
        if (Input.GetKeyDown(spawnKey) && Time.time >= nextSpawnTime)
        {
            SpawnCube();
            nextSpawnTime = Time.time + spawnCooldown;
        }
    }

    void SpawnCube()
    {
        // Always world forward (Z direction)
        Vector3 spawnPosition = transform.position + Vector3.forward * spawnDistance;

        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }
}