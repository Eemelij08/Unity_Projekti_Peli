using UnityEngine;

public class PelaajaSpawneri : MonoBehaviour
{
    public GameObject PelaajaPrefab1;
    public GameObject PelaajaPrefab2; 

    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnSyntymaYksin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPelaaja();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPelaaja()
    {
        if (Pistelaskuri.Instance.pelaajaMaara == 2)
        {
            GameObject playerInstance1 = Instantiate(PelaajaPrefab1, spawnPoint1.transform.position, Quaternion.identity);

            GameObject playerInstance2 = Instantiate(PelaajaPrefab2, spawnPoint2.transform.position, Quaternion.identity);
        }
        else
        {
            GameObject playerInstance = Instantiate(PelaajaPrefab1, spawnSyntymaYksin.transform.position, Quaternion.identity);
        }
        
    }
}
