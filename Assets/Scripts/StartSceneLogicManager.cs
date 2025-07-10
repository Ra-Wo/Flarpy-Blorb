using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneCanvasScript : MonoBehaviour
{
    void Start() { }

    public void StartGame()
    { // Load the scene additively first
        SceneManager.LoadScene("MainScene");
    }
}
