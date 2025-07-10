using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public int spawnInterval = 6; // Time in seconds between spawns
    private float timer = 0f;
    private int heightOffset = 8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawnInterval)
        {
            SpawnPipe();
            timer = 0f; // Reset the timer after spawning
        }
        else
        {
            timer += Time.deltaTime; // Increment the timer
        }
    }

    private void SpawnPipe()
    {
        float lowestY = transform.position.y - heightOffset;
        float highestY = transform.position.y + heightOffset;
        float randomY = Random.Range(lowestY, highestY);

        Instantiate(
            pipePrefab,
            new Vector3(transform.position.x, randomY, transform.position.z),
            transform.rotation
        );
    }
}
