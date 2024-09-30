using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeEndAnim : MonoBehaviour
{
    public Animator animatorLightLine; // Reference to Light Line the animation 
    public GameObject LightLine; // Reference to the Light Line object (with animation)



    public void OnTreeAnimationEnd()
    {
        
         // Check if LightLine is not active, then activate it
        if (!LightLine.activeSelf)
        {
            LightLine.SetActive(true);
        }
    
        animatorLightLine.Play("LightLineAnimation");
        
    }
}
