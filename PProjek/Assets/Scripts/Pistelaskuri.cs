using UnityEngine;
using UnityEngine.SceneManagement;

public class Pistelaskuri : MonoBehaviour
{
    public static Pistelaskuri Instance;

    public int score = 0;
    
    public bool isGameActive = false;

    public float spawnVali = 2f;

    //Pelaaja maara
    public int pelaajaMaara = 1;

    //KONAMI KOODI
    public int KONAMI = 0;


    //Hiiri

    public int Hiiri = 0;

    //level mode
    public int pisteet = 0;
    public int nextLevelCap = 10;
    public int levelNumber = 1;

    public AudioClip nextlevelsound;
    public AudioClip WinSound;
    public AudioClip ContinueWinSound;
    public AudioClip SelectWinSound;
    public AudioSource audioSource;

    public int continueMaara = 3;

    public int LevelSelectNumber = 0;

    public int ContinueUseNumber = 0;

    //Power aika laskuri
    //public int Laskuri = 0;
    public int poweri = 0;
    public int poweri2 = 0;

    public int Player2poweri = 0;
    public int Player2poweri2 = 0;

    public bool onKuolematon = false;



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {

        //power laskuri

        //if (Laskuri > 101)
        //{
        //    poweri = 0;
        //}

        //Level pista maara

        if (poweri2 == 2)
        {
           onKuolematon = true;
        }

        if (nextLevelCap < 11)
        {
            if(pisteet > nextLevelCap)
            {
                LevelTwo();
                audioSource.PlayOneShot(nextlevelsound);
                levelNumber++;
                pisteet = 0;
                nextLevelCap += 14;
                poweri = 0;
                poweri2 = 0;
            }
        }

        if (nextLevelCap < 25)
        {
            if (pisteet > nextLevelCap)
            {
                LevelThree();
                audioSource.PlayOneShot(nextlevelsound);
                levelNumber++;
                pisteet = 0;
                nextLevelCap += 26;
                poweri = 0;
                poweri2 = 0;
            }
        }

        if (nextLevelCap < 51)
        {
            if (pisteet > nextLevelCap)
            {
                LevelFour();
                audioSource.PlayOneShot(nextlevelsound);
                levelNumber++;
                pisteet = 0;
                nextLevelCap += 25;
                poweri = 0;
                poweri2 = 0;
            }
        }
        if (nextLevelCap < 76)
        {
            if (pisteet > nextLevelCap)
            {
                LevelFive();
                audioSource.PlayOneShot(nextlevelsound);
                levelNumber++;
                pisteet = 0;
                nextLevelCap += 25;
                poweri = 0;
                poweri2 = 0;
            }
        }
        if (nextLevelCap < 101)
        {
            if (pisteet > nextLevelCap)
            {
                LevelSix();
                audioSource.PlayOneShot(nextlevelsound);
                levelNumber++;
                pisteet = 0;
                nextLevelCap += 50;
                poweri = 0;
                poweri2 = 0;
            }
        }
        if (nextLevelCap < 151)
        {
            if (pisteet > nextLevelCap)
            {
                LevelSeven();
                audioSource.PlayOneShot(nextlevelsound);
                levelNumber++;
                pisteet = 0;
                nextLevelCap += 100;
                poweri = 0;
                poweri2 = 0;
            }
        }
        if (nextLevelCap < 251)
        {
            if (pisteet > nextLevelCap)
            {
                LevelEight();
                audioSource.PlayOneShot(nextlevelsound);
                levelNumber++;
                pisteet = 0;
                nextLevelCap += 150;
                poweri = 0;
                poweri2 = 0;
            }
        }
        if (nextLevelCap < 401)
        {
            if (pisteet > nextLevelCap)
            {
                if(LevelSelectNumber > 0)
                {
                    pisteet = 0;
                    audioSource.PlayOneShot(SelectWinSound);
                    FakeLevelWinScreen();
                    poweri = 0;
                    poweri2 = 0;
                }
                else if (ContinueUseNumber > 0)
                {
                    pisteet = 0;
                    audioSource.PlayOneShot(ContinueWinSound);
                    ContinueLevelWinScreen();
                    poweri = 0;
                    poweri2 = 0;
                }
                else
                {
                    pisteet = 0;
                    audioSource.PlayOneShot(WinSound);
                    LevelWinScreen();
                    poweri = 0;
                    poweri2 = 0;
                }
                
            }
        }
    }

    public void StartGame()
    {
        score = 0;
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("SampleScene");
    }
    public void StartGame2Player()
    {
        score = 0;
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("Endless2Player");
    }

    public void EndGame()
    {
        Hiiri = 0;
        isGameActive = false;
        SceneManager.LoadScene("EndScene");
        
    }
    public void EndGamePlayerTwo()
    {
        Hiiri = 0;
        isGameActive = false;
        SceneManager.LoadScene("EndScenePlayer2");

    }

    public void LevelEndGame()
    {
        Hiiri = 0;
        isGameActive = true;
        SceneManager.LoadScene("LevelEndScene");

    }

    public void LevelEndGamePlayerTwo()
    {
        Hiiri = 0;
        isGameActive = true;
        SceneManager.LoadScene("LevelEndScenePlayer2");

    }

    public void BackToMenu()
    {
        Hiiri = 0;
        isGameActive = true;
        SceneManager.LoadScene("MainMenu");

    }

    public void InfoMenu()
    {
        Hiiri = 0;
        isGameActive = true;
        SceneManager.LoadScene("InfoMenu");

    }

    public void LevelOne()
    {
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("LevelOne");
    }

    public void LevelTwo()
    {
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("LevelTwo");
        
    }

    public void LevelThree()
    {
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("LevelThree");

    }

    public void LevelFour()
    {
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("LevelFour");

    }

    public void LevelFive()
    {
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("LevelFive");

    }

    public void LevelSix()
    {
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("LevelSix");

    }

    public void LevelSeven()
    {
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("LevelSeven");

    }

    public void LevelEight()
    {
        Hiiri = 1;
        isGameActive = true;
        SceneManager.LoadScene("LevelEight");

    }

    public void LevelSelect()
    {
        Hiiri = 0;
        isGameActive = true;
        SceneManager.LoadScene("LevelSelect");

    }

    public void LevelWinScreen()
    {
        Hiiri = 0;
        isGameActive = true;
        SceneManager.LoadScene("LevelWinScreen");

    }
    public void FakeLevelWinScreen()
    {
        Hiiri = 0;
        isGameActive = true;
        SceneManager.LoadScene("FakeLevelWinScreen");

    }

    public void ContinueLevelWinScreen()
    {
        Hiiri = 0;
        isGameActive = true;
        SceneManager.LoadScene("ContinueLevelWinScreen");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}