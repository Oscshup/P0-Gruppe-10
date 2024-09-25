using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        // Check if the game is running in the Unity editor
        #if UNITY_EDITOR
            // Stop playing the game in the editor
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // Quit the application when running in a standalone build
            Application.Quit();
        #endif
    }
}