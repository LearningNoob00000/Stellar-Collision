using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYAUDIO : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        // Find the AudioSource component in the scene
        audioSource = GameObject.Find("YourAudioSourceGameObject").GetComponent<AudioSource>();
    }

    public void PlayAudioOnClick()
    {
        // Play the audio clip
        audioSource.Play();
    }
}
