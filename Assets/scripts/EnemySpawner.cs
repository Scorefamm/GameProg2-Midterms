using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; // Assign your 3 prefabs in the Inspector
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 5.0f;

    void Start()
    {
        // Start the infinite spawning loop
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            // Pick a random time before spawning
            float randomDelay = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(randomDelay);

            // Spawn random prefab
            GameObject prefab = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)];

            // Spawn at the spawner's current position and rotation
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}