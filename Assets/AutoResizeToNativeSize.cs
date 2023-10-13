using UnityEngine;
using UnityEngine.UI;

public class AutoResizeToNativeSize : MonoBehaviour
{
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (image.sprite != null)
        {
            // Set the image size to match the native size of the sprite
            image.SetNativeSize();
        }
    }
}
