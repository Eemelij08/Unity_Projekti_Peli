using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class EndScreen : MonoBehaviour
{

    //Endless
    public TextMeshProUGUI PisteMaara;

    //Level
    


    private void Start()
    {
        if (Pistelaskuri.Instance.score == 1)
        {
            PisteMaara.text = "You dodged " + Pistelaskuri.Instance.score + " brick";

        }
        else
        {
            PisteMaara.text = "you dodged " + Pistelaskuri.Instance.score + " brick's";

        }

        
        

    }



    public void BackToMenu()
    {
        
        SceneManager.LoadScene("MainMenu");
        
    }
}
