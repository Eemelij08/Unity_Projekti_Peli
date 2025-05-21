using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Audio;

public class MenuNapit : MonoBehaviour
{
    public AudioClip explosionSound;

    public AudioSource audioSource;


    public void StartGame()
    {
        Pistelaskuri.Instance.StartGame();
    }

    public void QuitGame()
    {
        Pistelaskuri.Instance.QuitGame();
    }

    public void BackToMenu()
    {
        Pistelaskuri.Instance.pisteet = 0;
        Pistelaskuri.Instance.nextLevelCap = 10;
        Pistelaskuri.Instance.levelNumber = 1;
        Pistelaskuri.Instance.BackToMenu();
        Pistelaskuri.Instance.continueMaara = 3;
        Pistelaskuri.Instance.LevelSelectNumber = 0;
        Pistelaskuri.Instance.ContinueUseNumber = 0;
        Pistelaskuri.Instance.poweri = 0;
        Pistelaskuri.Instance.poweri2 = 0;
    }

    public void InfoMenu()
    {
        Pistelaskuri.Instance.InfoMenu();
    }


    public void LevelOne()
    {
        Pistelaskuri.Instance.LevelOne();
    }

    public void LevelTwo()
    {
        Pistelaskuri.Instance.LevelTwo();
        Pistelaskuri.Instance.levelNumber = 2;
        Pistelaskuri.Instance.pisteet = 0;
        Pistelaskuri.Instance.nextLevelCap = 24;
        Pistelaskuri.Instance.LevelSelectNumber = 1;
    }

    public void LevelThree()
    {
        Pistelaskuri.Instance.LevelThree();
        Pistelaskuri.Instance.levelNumber = 3;
        Pistelaskuri.Instance.pisteet = 0;
        Pistelaskuri.Instance.nextLevelCap = 50;
        Pistelaskuri.Instance.LevelSelectNumber = 1;
    }

    public void LevelFour()
    {
        Pistelaskuri.Instance.LevelFour();
        Pistelaskuri.Instance.levelNumber = 4;
        Pistelaskuri.Instance.pisteet = 0;
        Pistelaskuri.Instance.nextLevelCap = 75;
        Pistelaskuri.Instance.LevelSelectNumber = 1;
    }
    public void LevelFive()
    {
        Pistelaskuri.Instance.LevelFive();
        Pistelaskuri.Instance.levelNumber = 5;
        Pistelaskuri.Instance.pisteet = 0;
        Pistelaskuri.Instance.nextLevelCap = 100;
        Pistelaskuri.Instance.LevelSelectNumber = 1;
    }

    public void LevelSix()
    {
        Pistelaskuri.Instance.LevelSix();
        Pistelaskuri.Instance.levelNumber = 6;
        Pistelaskuri.Instance.pisteet = 0;
        Pistelaskuri.Instance.nextLevelCap = 150;
        Pistelaskuri.Instance.LevelSelectNumber = 1;
    }
    public void LevelSeven()
    {
        Pistelaskuri.Instance.LevelSeven();
        Pistelaskuri.Instance.levelNumber = 7;
        Pistelaskuri.Instance.pisteet = 0;
        Pistelaskuri.Instance.nextLevelCap = 250;
        Pistelaskuri.Instance.LevelSelectNumber = 1;
    }
    public void LevelEight()
    {
        Pistelaskuri.Instance.LevelEight();
        Pistelaskuri.Instance.levelNumber = 8;
        Pistelaskuri.Instance.pisteet = 0;
        Pistelaskuri.Instance.nextLevelCap = 400;
        Pistelaskuri.Instance.LevelSelectNumber = 1;
    }

    public void LevelSelect()
    {
        Pistelaskuri.Instance.LevelSelect();
    }

    public void Continue()
    {
        if (Pistelaskuri.Instance.continueMaara > 0)
        {
            if (Pistelaskuri.Instance.levelNumber == 1)
            {
                Pistelaskuri.Instance.LevelOne();
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 10;
                Pistelaskuri.Instance.levelNumber = 1;
                Pistelaskuri.Instance.continueMaara--;
                Pistelaskuri.Instance.ContinueUseNumber++;
            }

            if (Pistelaskuri.Instance.levelNumber == 2)
            {
                Pistelaskuri.Instance.LevelTwo();
                Pistelaskuri.Instance.levelNumber = 2;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 24;
                Pistelaskuri.Instance.continueMaara--;
                Pistelaskuri.Instance.ContinueUseNumber++;
            }

            if (Pistelaskuri.Instance.levelNumber == 3)
            {
                Pistelaskuri.Instance.LevelThree();
                Pistelaskuri.Instance.levelNumber = 3;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 50;
                Pistelaskuri.Instance.continueMaara--;
                Pistelaskuri.Instance.ContinueUseNumber++;
            }

            if (Pistelaskuri.Instance.levelNumber == 4)
            {
                Pistelaskuri.Instance.LevelFour();
                Pistelaskuri.Instance.levelNumber = 4;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 75;
                Pistelaskuri.Instance.continueMaara--;
                Pistelaskuri.Instance.ContinueUseNumber++;
            }

            if (Pistelaskuri.Instance.levelNumber == 5)
            {
                Pistelaskuri.Instance.LevelFive();
                Pistelaskuri.Instance.levelNumber = 5;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 100;
                Pistelaskuri.Instance.continueMaara--;
                Pistelaskuri.Instance.ContinueUseNumber++;
            }

            if (Pistelaskuri.Instance.levelNumber == 6)
            {
                Pistelaskuri.Instance.LevelSix();
                Pistelaskuri.Instance.levelNumber = 6;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 150;
                Pistelaskuri.Instance.continueMaara--;
                Pistelaskuri.Instance.ContinueUseNumber++;
            }

            if (Pistelaskuri.Instance.levelNumber == 7)
            {
                Pistelaskuri.Instance.LevelSeven();
                Pistelaskuri.Instance.levelNumber = 7;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 250;
                Pistelaskuri.Instance.continueMaara--;
                Pistelaskuri.Instance.ContinueUseNumber++;
            }

            if (Pistelaskuri.Instance.levelNumber == 8)
            {
                Pistelaskuri.Instance.LevelEight();
                Pistelaskuri.Instance.levelNumber = 8;
                Pistelaskuri.Instance.pisteet = 0;
                Pistelaskuri.Instance.nextLevelCap = 400;
                Pistelaskuri.Instance.continueMaara--;
                Pistelaskuri.Instance.ContinueUseNumber++;
            }

        }
        else
        {
            Debug.Log("Continuetloppu");
        }
        
    }

    public void onClick()
    {
        audioSource.PlayOneShot(explosionSound);
    }



}
