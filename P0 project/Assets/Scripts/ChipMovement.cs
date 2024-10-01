using System.Collections;
using UnityEngine;

public class ChipMovement : MonoBehaviour
{
    public Transform midPoint;  // Chip first stop
    public Transform endPoint;  // End point, delete the chip
    public float fallSpeed = 2f;  // Speed for the movement to first point
    public float moveSpeed = 3f;  // Speed for the movement to end point

    private bool isMovingToMid = true;  // Check the chip move to mid point
    private bool isWaitingForClick = false;  // Wait to chip are in mid to click
    private bool isMovingToEnd = false;  // Check the chip move to end point
    public Animator animatorLighting; // Reference to Lighting the animation 
    public GameObject Lighting; // Reference to the Lighting panel object (with animation)
     
    void Update()
    {
        if (isMovingToMid)
        {
            MoveToMidPoint();
        }
        else if (isWaitingForClick && Input.GetMouseButtonDown(0))  // Wait click
        {
            isWaitingForClick = false;
            isMovingToEnd = true;  // Begin to move the end
        }

        if (isMovingToEnd)
        {
            MoveToEndPoint();
        }
    }

    void MoveToMidPoint()
    {
        // Move the chip to mid
        transform.position = Vector2.MoveTowards(transform.position, midPoint.position, fallSpeed * Time.deltaTime);

        // When the chip on mid
        if (Vector2.Distance(transform.position, midPoint.position) < 0.1f)
        {
            isMovingToMid = false;  // Stop movement
            isWaitingForClick = true;  // wait for the click to continue 
        }
    }

    void MoveToEndPoint()
    {
        // Move to the end
        transform.position = Vector2.MoveTowards(transform.position, endPoint.position, moveSpeed * Time.deltaTime);

        // When the chip reaches the end point
        if (Vector2.Distance(transform.position, endPoint.position) < 0.1f)
        {
            Destroy(gameObject);  //Delete the chip
            Debug.Log("Start Tree");
            
            // Activate the lighting and start its animation
            Lighting.SetActive(true);
            animatorLighting.Play("LightingRootsAnimation");

                       
        }
    }
}
