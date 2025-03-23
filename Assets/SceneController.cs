using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string gameScene;
    public string tutorialScene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goToGame() {
        Debug.Log("goToGame: " + gameScene);

        // Directly load the "multiplayer" scene
        SceneManager.LoadScene(gameScene);
    }

    public void goToTutorial() {
        Debug.Log("goToTutorial: " + tutorialScene);

        // Directly load the "multiplayer" scene
        SceneManager.LoadScene(tutorialScene);
    }
}