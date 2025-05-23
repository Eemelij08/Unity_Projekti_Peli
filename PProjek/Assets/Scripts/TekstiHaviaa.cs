using System.Globalization;
using TMPro;
using UnityEngine;
public class TekstiHaviaa : MonoBehaviour
{
    public TextMeshProUGUI HaviavaTeksti;
    public TextMeshProUGUI HaviavaTeksti2;
    public float aika = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Pistelaskuri.Instance.pelaajaMaara == 2)
        {
            Destroy(HaviavaTeksti, aika);
            Destroy(HaviavaTeksti2, aika);
        }
        else
        {
            Destroy(HaviavaTeksti2);
            Destroy(HaviavaTeksti, aika);
        }
        
    }
}
