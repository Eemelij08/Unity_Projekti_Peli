using UnityEngine;

public class HedelmaSpawneri : MonoBehaviour
{
    public GameObject HedelmaPrefab;

    public GameObject VihriaHedelmaPrefab;

    public float SpawniVali = 10f;

    public int numero = 1; // Kuinka usein pudotetaan hedelma

    public Vector2 spawnArea = new Vector2(5f, 5f);

    public float spawnHeight = 1f;


    void Start()

    {

        InvokeRepeating("Spawner", 1f, SpawniVali);

    }

    void Spawner()
    {
        if (numero == 1)
        {
            SpawnHedelma();
        }

        if (numero == 2)
        {
            SpawnVihriaHedelma();
        }

        if(numero == 3)
        {
            SpawnVihriaHedelma();
            SpawnHedelma();
        }
    }
    void SpawnHedelma()
    {
        Debug.Log("Hedelma");
        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );



        Instantiate(HedelmaPrefab, spawnPos, Quaternion.identity);



    }

    void SpawnVihriaHedelma()
    {
        Debug.Log("VihriaHedelma");
        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );



        Instantiate(VihriaHedelmaPrefab, spawnPos, Quaternion.identity);



    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        
    }
}
