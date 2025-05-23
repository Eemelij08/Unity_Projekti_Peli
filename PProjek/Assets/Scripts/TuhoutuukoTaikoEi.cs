using UnityEngine;

public class TuhoutuukoTaikoEi : MonoBehaviour
{

    public GameObject pelaaja2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pistelaskuri.Instance.pelaajaMaara == 1)
        {
            Destroy(pelaaja2);
        }
    }
}
