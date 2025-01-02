using System.Collections;
using UnityEngine;

public class DelayedAudio : MonoBehaviour
{
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null)
        {
            // Start the delayed playback
            StartCoroutine(PlayAudioWithDelay(7.4f));
        }
        else
        {
            Debug.LogWarning("AudioSource component not found on this GameObject.");
        }
    }

    IEnumerator PlayAudioWithDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Play the audio
        audioSource.Play();
    }
}
