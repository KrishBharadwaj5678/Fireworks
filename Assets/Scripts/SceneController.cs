using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Button button1; // Reference to button 1
    public Button button2; // Reference to button 2
    public Button button3; // Reference to button 3

    private void Start()
    {
        // Assign listeners to the buttons
        button1.onClick.AddListener(() => LoadScene("Firecracker"));
        button2.onClick.AddListener(() => LoadScene("Rockets"));
        button3.onClick.AddListener(() => LoadScene("SkyShots"));
    }

    // Method to load the scene by name
    void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
