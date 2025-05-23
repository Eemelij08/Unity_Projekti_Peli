using UnityEngine;

public class TiiliTuhoutuminen : MonoBehaviour
{

    public GameObject explosionEffectPrefab;


    public AudioClip explosionSound;





    void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.CompareTag("Maa"))
        {


            AudioSource.PlayClipAtPoint(explosionSound, transform.position);

            
            // Instansioi räjähdys

            //Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);


            Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);

            


            Destroy(gameObject);
            //Endless muoto
            Pistelaskuri.Instance.score++;

            //Level muoto
            //Pistelaskuri.Instance.pisteet++;


        }

        if (collision.gameObject.CompareTag("LevelMaa"))
        {
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);

            Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);

            Destroy(gameObject);

            if (gameObject.CompareTag("Tiili"))
            {
                Pistelaskuri.Instance.pisteet++;
            }

            //Pistelaskuri.Instance.pisteet++;


        }

        if (Pistelaskuri.Instance.onKuolematon == false)
        {
            if (collision.gameObject.CompareTag("Pelaaja"))
            {
                Pistelaskuri.Instance.LevelEndGame();
            }
        }

        //Pelaaja2
        if (Pistelaskuri.Instance.onKuolematon == false)
        {
            if (collision.gameObject.CompareTag("Pelaaja2"))
            {
                Pistelaskuri.Instance.LevelEndGamePlayerTwo();
            }
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Pistelaskuri.Instance.EndGame();
        }
        //Pelaaja2
        if (collision.gameObject.CompareTag("Player2"))
        {
            Pistelaskuri.Instance.EndGamePlayerTwo();
        }

        //Level muoto


        Destroy(gameObject, 10f);

    }

}
