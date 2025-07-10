using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float deadZone = -27f; // X position where the pipe is considered out of bounds

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * new Vector3(-1, 0, 0);

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
