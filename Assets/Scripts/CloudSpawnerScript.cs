using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloudPrefab; // Prefab for the cloud object
    public float spawnInterval = 5f; // Time interval between spawns
    public float spawnRangeX = 14f; // Range for random X position
    public float timer = 0; // Timer to track the number of spawns

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnInterval) // Adjust the condition as needed for your game logic
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0; // Reset the timer after spawning
        }
    }

    private void SpawnCloud()
    {
        float maxY = transform.position.y + spawnRangeX;
        float minY = transform.position.y - spawnRangeX;
        float randomY = Random.Range(maxY, minY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);
        Instantiate(cloudPrefab, spawnPosition, Quaternion.identity);
    }
}
