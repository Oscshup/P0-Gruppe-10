using UnityEngine;

public class AnimationEventBridge : MonoBehaviour
{
    public Animator animator; //Tree animator
    public ManagerScript managerScript; 

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1 && !animator.IsInTransition(0))
        {
            // Call ShowColorPanels if the animation has finished
            managerScript.ShowColorPanels();
            enabled = false; // Disable this script after calling to prevent repeated calls
        }
    }
}
