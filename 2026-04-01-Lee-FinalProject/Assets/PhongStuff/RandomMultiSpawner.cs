using UnityEngine;

public class RandomMultiSpawner : MonoBehaviour
{
    public GameObject prefab;
    public BoxCollider spawnArea;

    public float spawnInterval = 5f;
    public int minSpawn = 1;
    public int maxSpawn = 5;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBatch), 0f, spawnInterval);
    }

    void SpawnBatch()
    {
        int count = Random.Range(minSpawn, maxSpawn + 1);

        for (int i = 0; i < count; i++)
        {
            Vector3 pos = GetRandomPointInBox(spawnArea);
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }

    Vector3 GetRandomPointInBox(BoxCollider box)
    {
        Vector3 center = box.transform.position + box.center;
        Vector3 size = box.size;

        Vector3 randomPos = new Vector3(
            Random.Range(-size.x / 2f, size.x / 2f),
            Random.Range(-size.y / 2f, size.y / 2f),
            Random.Range(-size.z / 2f, size.z / 2f)
        );

        return center + box.transform.TransformVector(randomPos);
    }
}