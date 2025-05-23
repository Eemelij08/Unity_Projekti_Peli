using UnityEngine;
using UnityEngine.Audio;

public class Deeebuggi : MonoBehaviour
{
    public int ylaNuoli = 0;
    public int alaNuoli = 0;

    public int vasenNuoli = 0;
    public int vasenNuoli2 = 0;
    public int OikeaNuoli = 0;
    public int OikeaNuoli2 = 0;

    public int aNappi = 0;
    public int bNappi = 0;

    public AudioClip KonamiKoodi;
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            ylaNuoli++;
            alaNuoli = 0;
            vasenNuoli = 0;
            vasenNuoli2 = 0;
            OikeaNuoli = 0;
            OikeaNuoli2 = 0;
            aNappi = 0;
            bNappi = 0;
            Debug.Log("Ylös");
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (ylaNuoli == 2)
            {
                alaNuoli++;
                Debug.Log("Alas");
            }
            else
            {
                ylaNuoli = 0;
                alaNuoli = 0;
                vasenNuoli = 0;
                vasenNuoli2 = 0;
                OikeaNuoli = 0;
                OikeaNuoli2 = 0;
                aNappi = 0;
                bNappi = 0;
                Debug.Log("Virhe");
            }
           
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (alaNuoli == 2)
            {
                if (vasenNuoli == 0)
                {
                    vasenNuoli++;
                    Debug.Log("Vasen");
                }

            }
            else if (OikeaNuoli == 1)
            {
                vasenNuoli2++;
                vasenNuoli++;
                Debug.Log("Vasen");
            }
            else
            {
                ylaNuoli = 0;
                alaNuoli = 0;
                vasenNuoli = 0;
                vasenNuoli2 = 0;
                OikeaNuoli = 0;
                OikeaNuoli2 = 0;
                aNappi = 0;
                bNappi = 0;
                Debug.Log("Virhe");
            }

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (vasenNuoli == 1)
            {
                if (OikeaNuoli == 0)
                {
                    OikeaNuoli++;
                    alaNuoli++;
                    Debug.Log("Oikee");
                }

            }
            else if (vasenNuoli2 == 1)
            {
                OikeaNuoli2++;
                Debug.Log("Oikee");
            }
         
            else
            {
                ylaNuoli = 0;
                alaNuoli = 0;
                vasenNuoli = 0;
                vasenNuoli2 = 0;
                OikeaNuoli = 0;
                OikeaNuoli2 = 0;
                aNappi = 0;
                bNappi = 0;
                Debug.Log("Virhe");
            }

        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            if (ylaNuoli == 2 & alaNuoli == 3 & vasenNuoli == 2 & vasenNuoli2 == 1 & OikeaNuoli == 1 & OikeaNuoli2 == 1 )
            {
                aNappi++;
                Debug.Log("B");
            }
            else
            {
                ylaNuoli = 0;
                alaNuoli = 0;
                vasenNuoli = 0;
                vasenNuoli2 = 0;
                OikeaNuoli = 0;
                OikeaNuoli2 = 0;
                aNappi = 0;
                bNappi = 0;
                Debug.Log("Virhe");
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (aNappi == 1 & ylaNuoli == 2 & alaNuoli == 3 & vasenNuoli == 2 & vasenNuoli2 == 1 & OikeaNuoli == 1 & OikeaNuoli2 == 1)
            {
                Pistelaskuri.Instance.KONAMI = 1;
                audioSource.PlayOneShot(KonamiKoodi);
                Debug.Log("A");
                Debug.Log("KONAMI");
            }
            else
            {
                ylaNuoli = 0;
                alaNuoli = 0;
                vasenNuoli = 0;
                vasenNuoli2 = 0;
                OikeaNuoli = 0;
                OikeaNuoli2 = 0;
                aNappi = 0;
                bNappi = 0;
                Debug.Log("Virhe");
            }
        }
        
        if (Pistelaskuri.Instance.KONAMI == 1)
        {
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                Pistelaskuri.Instance.LevelTwo();
                Pistelaskuri.Instance.levelNumber = 2;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 24;
            }

            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                Pistelaskuri.Instance.LevelThree();
                Pistelaskuri.Instance.levelNumber = 3;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 50;
            }

            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                Pistelaskuri.Instance.LevelFour();
                Pistelaskuri.Instance.levelNumber = 4;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 75;
            }

            if (Input.GetKeyUp(KeyCode.Alpha4))
            {
                Pistelaskuri.Instance.LevelFive();
                Pistelaskuri.Instance.levelNumber = 5;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 100;
            }

            if (Input.GetKeyUp(KeyCode.Alpha5))
            {
                Pistelaskuri.Instance.LevelSix();
                Pistelaskuri.Instance.levelNumber = 6;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 150;
            }

            if (Input.GetKeyUp(KeyCode.Alpha6))
            {
                Pistelaskuri.Instance.LevelSeven();
                Pistelaskuri.Instance.levelNumber = 7;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 250;
            }
            if (Input.GetKeyUp(KeyCode.Alpha7))
            {
                Pistelaskuri.Instance.LevelEight();
                Pistelaskuri.Instance.levelNumber = 8;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 400;
            }
            if (Input.GetKeyUp(KeyCode.Alpha8))
            {
                Pistelaskuri.Instance.FakeLevelWinScreen();
                Pistelaskuri.Instance.levelNumber = 8;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 400;
            }

            if (Input.GetKeyUp(KeyCode.Alpha9))
            {
                Pistelaskuri.Instance.ContinueLevelWinScreen();
                Pistelaskuri.Instance.levelNumber = 8;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 400;
            }
            if (Input.GetKeyUp(KeyCode.Alpha0))
            {
                Pistelaskuri.Instance.LevelWinScreen();
                Pistelaskuri.Instance.levelNumber = 8;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 400;
            }
        }
        /*if (Input.GetKeyUp(KeyCode.Q))
        {
            Pistelaskuri.Instance.LevelTwo();
            Pistelaskuri.Instance.levelNumber=2;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 24;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Pistelaskuri.Instance.LevelThree();
            Pistelaskuri.Instance.levelNumber = 3;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 50;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            Pistelaskuri.Instance.LevelFour();
            Pistelaskuri.Instance.levelNumber = 4;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 75;
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            Pistelaskuri.Instance.LevelFive();
            Pistelaskuri.Instance.levelNumber = 5;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 100;
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            Pistelaskuri.Instance.LevelSix();
            Pistelaskuri.Instance.levelNumber = 6;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 150;
        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            Pistelaskuri.Instance.LevelSeven();
            Pistelaskuri.Instance.levelNumber = 7;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 250;
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            Pistelaskuri.Instance.LevelEight();
            Pistelaskuri.Instance.levelNumber = 8;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 400;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            Pistelaskuri.Instance.FakeLevelWinScreen();
            Pistelaskuri.Instance.levelNumber = 8;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 400;
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            Pistelaskuri.Instance.ContinueLevelWinScreen();
            Pistelaskuri.Instance.levelNumber = 8;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 400;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            Pistelaskuri.Instance.LevelWinScreen();
            Pistelaskuri.Instance.levelNumber = 8;
            Pistelaskuri.Instance.pisteet = 0;
            Pistelaskuri.Instance.nextLevelCap = 400;
        }
        */

    }
}
