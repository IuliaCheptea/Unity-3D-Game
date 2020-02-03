using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool gameHasEnded = false;
    public float restartDelay = 1f;
    public Text currentLevel;

    public GameObject completeLevelUI;
    public GameObject startLevelUI;

    public void Start()
    {
        //this.StartLevel();
    }

    public void FixedUpdate()
    {
        if (Input.GetKey("escape"))
        {
            EditorApplication.isPlaying = false;
        }
    }

    public void StartLevel()
    {
        Debug.Log("Starting level: " + SceneManager.GetActiveScene().buildIndex);
        currentLevel.text = SceneManager.GetActiveScene().buildIndex.ToString();
        //startLevelUI.SetActive(true);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level completed.");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over.");
            Invoke("Restart", restartDelay);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
