using UnityEngine;

public class VihriaHedelmaTuhoutuminen : MonoBehaviour
{
    public AudioClip eatingsound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)

    {



        //Level muoto
        if (collision.gameObject.CompareTag("Pelaaja"))
        {
            if (Pistelaskuri.Instance.poweri2 == 2)
            {
                Debug.Log("Olet jo syany vihrian marijan");
            }
            else
            {
                AudioSource.PlayClipAtPoint(eatingsound, transform.position);
                Pistelaskuri.Instance.poweri2 = 2;
                Destroy(gameObject);
            }
        }

        Destroy(gameObject, 20f);

    }
}
