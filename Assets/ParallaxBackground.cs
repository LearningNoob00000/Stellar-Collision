using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    private Material material;
    private Vector2 offset;

    private void Start()
    {
        // Get the material of the sprite renderer
        material = GetComponent<Renderer>().material;
        offset = material.mainTextureOffset;
    }

    private void Update()
    {
        // Calculate the new offset based on time and speed
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        offset = new Vector2(x, offset.y);

        // Apply the offset to the material
        material.mainTextureOffset = offset;
    }
}
