using UnityEngine;

public class Cheer : MonoBehaviour
{
    public float span = 600.0f;
    private float currentTime;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > span)
        {
            audioSource.Play();
            currentTime = 0.0f;
        }
    }
}