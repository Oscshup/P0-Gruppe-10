using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Get the camera's orthographic size and aspect ratio
        float cameraHeight = 2f * Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * Camera.main.aspect;

        // Get the sprite's size in world units
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        float spriteWidth = sr.sprite.bounds.size.x;
        float spriteHeight = sr.sprite.bounds.size.y;

        // Calculate the scale factor to fit the width
        Vector3 scale = transform.localScale;
        scale.x = cameraWidth / spriteWidth;
        scale.y = cameraHeight / spriteHeight;

        // Apply the new scale
        transform.localScale = scale;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
