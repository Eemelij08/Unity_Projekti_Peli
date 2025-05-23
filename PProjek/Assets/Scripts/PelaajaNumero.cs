using System.Globalization;
using TMPro;
using UnityEngine;
public class PelaajaNumero : MonoBehaviour
{
    public TextMeshProUGUI pelaajaNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pelaajaNumber.text = Pistelaskuri.Instance.pelaajaMaara.ToString();
    }
}
