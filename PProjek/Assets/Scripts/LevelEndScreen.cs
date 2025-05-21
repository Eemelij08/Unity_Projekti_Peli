using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndScreen : MonoBehaviour
{
    public TextMeshProUGUI Kentta;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Kentta.text = "You got into level " + Pistelaskuri.Instance.levelNumber;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu()
    {

        SceneManager.LoadScene("MainMenu");

    }
}
