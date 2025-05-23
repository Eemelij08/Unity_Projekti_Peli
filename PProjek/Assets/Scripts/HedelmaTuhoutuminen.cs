using UnityEngine;

public class HedelmaTuhoutuminen : MonoBehaviour
{
    public AudioClip eatingsound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)

    {



        //Level muoto
        if (collision.gameObject.CompareTag("Pelaaja"))
        {
            
            AudioSource.PlayClipAtPoint(eatingsound, transform.position);
            Pistelaskuri.Instance.poweri = 1;
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Pelaaja2"))
        {

            AudioSource.PlayClipAtPoint(eatingsound, transform.position);
            Pistelaskuri.Instance.Player2poweri = 1;
            Destroy(gameObject);
        }

        Destroy(gameObject, 20f);

    }
}
