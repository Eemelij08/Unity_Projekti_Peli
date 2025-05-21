using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VaikeustasoSaadin : MonoBehaviour
{

    public TextMeshProUGUI SaadinArvo;

    public Slider vaikeusSlider;


    void Start()
    {
        Pistelaskuri.Instance.spawnVali = vaikeusSlider.value;
        vaikeusSlider.onValueChanged.AddListener(MuutaVaikeusastetta);
    }

    public void MuutaVaikeusastetta(float uusiArvo)
    {
        Pistelaskuri.Instance.spawnVali = uusiArvo;
        NaytaArvo(uusiArvo);
    }

    void NaytaArvo(float uusiArvo)
    {
        SaadinArvo.text = uusiArvo.ToString("0.00");
    }
}
