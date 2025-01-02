using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButtonController : MonoBehaviour
{
    public Button backButton; // Reference to the back button

    private void Start()
    {
        // Add a listener to the button that calls the GoToHomeScene function
        backButton.onClick.AddListener(GoToHomeScene);
    }

    // Function to load the home scene
    void GoToHomeScene()
    {
        // Change "HomeScene" to the actual name of your home scene
        SceneManager.LoadScene("HomeScreen");
    }
}
