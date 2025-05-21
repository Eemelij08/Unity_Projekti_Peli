using System.Globalization;
using TMPro;
using UnityEngine;

public class KuinkaMontaTiilia : MonoBehaviour
{

    public TextMeshProUGUI TiiliMennyt;
    public TextMeshProUGUI TasoNumero;
    public int max = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TiiliMennyt.text = Pistelaskuri.Instance.pisteet.ToString() + "/" + max;
        TasoNumero.text = "Level " + Pistelaskuri.Instance.levelNumber.ToString();

    }
}
