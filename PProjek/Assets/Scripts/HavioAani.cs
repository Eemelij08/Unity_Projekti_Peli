using UnityEngine;

public class HavioAani : MonoBehaviour
{
    public AudioClip backgroundMusic;

    private AudioSource audioSource;



    void Start()

    {

        audioSource = GetComponent<AudioSource>();

        audioSource.clip = backgroundMusic;

        audioSource.loop = false;

        //audioSource.volume = 0.5f;

        audioSource.Play();

    }
}
