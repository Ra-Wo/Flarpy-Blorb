using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the cloud moves
    public float deadZone = -27f; // X position where the cloud is considered out of bounds

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject); // Destroy the cloud if it goes out of bounds
        }
        else
        {
            transform.position += moveSpeed * Time.deltaTime * new Vector3(-1, 0, 0); // Move the cloud left
        }
    }
}
