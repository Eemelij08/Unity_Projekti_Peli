using UnityEngine;

public class Deeebuggi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
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

    }
}
