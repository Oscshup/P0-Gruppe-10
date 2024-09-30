using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour // Make sure this matches the script filename
{
    public GameObject[] colorPanels; // Array to store the color panels
    
    // Method to enable color panels
    public void ShowColorPanels()
    {
        foreach (GameObject panel in colorPanels)
        {
            panel.SetActive(true);
        }
    }

}
