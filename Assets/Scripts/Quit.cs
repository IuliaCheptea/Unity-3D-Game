using UnityEngine;
using UnityEditor;

public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("QUIT");
        EditorApplication.isPlaying = false;
        //Application.Quit();
    }
}
