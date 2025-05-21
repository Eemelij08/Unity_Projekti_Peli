using System.Globalization;
using TMPro;
using UnityEngine;

public class JatkonMaara : MonoBehaviour
{

    public TextMeshProUGUI ContinuenMaara;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Pistelaskuri.Instance.continueMaara > 0)
        {
            ContinuenMaara.text = Pistelaskuri.Instance.continueMaara.ToString();
        }
        else
        {
            ContinuenMaara.text = "No more continues left!!";
        }

    }
}
