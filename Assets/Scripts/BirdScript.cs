using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flapStrength = 4f;
    public LogicManagerScript logicManagerScript;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicManagerScript = GameObject
            .FindGameObjectWithTag("LogicManager")
            .GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!birdIsAlive)
        {
            return; // If the bird is not alive, do not process input
        }
        // if the player hit the screen, make the bird flaps
        if (
            Mouse.current.leftButton.wasPressedThisFrame
            || (
                Touchscreen.current != null
                && Touchscreen.current.primaryTouch.phase.ReadValue()
                    == UnityEngine.InputSystem.TouchPhase.Began
            )
        )
        {
            Flap();
        }

        if (transform.position.y < -15 || transform.position.y > 15)
        {
            // if the bird falls below a certain height, game over
            birdIsAlive = false;
            logicManagerScript.GameOver();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // if the bird collides with a pipe, game over
        if (collision.gameObject.CompareTag("Pipe"))
        {
            birdIsAlive = false;
            logicManagerScript.GameOver();
        }
    }

    private void Flap()
    {
        myRigidbody2D.linearVelocity = Vector2.up * flapStrength;
    }
}
