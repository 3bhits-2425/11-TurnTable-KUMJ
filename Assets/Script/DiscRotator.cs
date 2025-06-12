using UnityEngine;

public class DiscRotator : MonoBehaviour
{
    public AudioSource audioSource;
    public float rotationSpeed = 100f; // degrees per second

    void Update()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
}
