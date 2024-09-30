using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigtingRootEnd : MonoBehaviour
{
   public Animator animatorTree; // Reference to Tree the animation 
    public GameObject Tree; // Reference to the Tree panel object (with animation)

    public GameObject RemoveLightningRoot;


    public void OnLightingAnimationEnd()
    {
        Destroy(RemoveLightningRoot);  
        Debug.Log("Lighting animation done, starting tree animation.");
        
        if (!Tree.activeSelf)
        {
            Tree.SetActive(true);
            
        }

        animatorTree.Play("TreeAnimation");
        
    }
}
