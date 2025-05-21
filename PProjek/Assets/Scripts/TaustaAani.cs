using UnityEngine;

public class TaustaAani : MonoBehaviour

{

    public AudioClip backgroundMusic;

    private AudioSource audioSource;



    void Start()

    {

        audioSource = GetComponent<AudioSource>();

        audioSource.clip = backgroundMusic;

        audioSource.loop = true;

        //audioSource.volume = 0.5f;

        audioSource.Play();

    }

}
