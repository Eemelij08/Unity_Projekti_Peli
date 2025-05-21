using System.Globalization;
using TMPro;
using UnityEngine;
public class TekstiHaviaa : MonoBehaviour
{
    public TextMeshProUGUI HaviavaTeksti;
    public float aika = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(HaviavaTeksti, aika);
    }
}
