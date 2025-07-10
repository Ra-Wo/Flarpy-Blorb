using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public LogicManagerScript logicManagerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicManagerScript = GameObject
            .FindGameObjectWithTag("LogicManager")
            .GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            logicManagerScript.AddScore();
        }
    }
}
