using System.Net;
using UnityEngine;

public class PeliManageri : MonoBehaviour
{

    public GameObject tiiliPrefab;          

    //public float spawnInterval = 2f;       

    public Vector2 spawnArea = new Vector2(10f, 10f); 

    public float spawnHeight = 10f;      

    //int numero = 0;

    void Start()

    {

        //InvokeRepeating("SpawnBrick", 1f, spawnInterval);

        //spawnInterval -= 0.1f;

        //InvokeRepeating("SpawnBrick", 1f, Pistelaskuri.Instance.spawnVali);

        //Pistelaskuri.Instance.spawnVali -= 0.1f;

        if(Pistelaskuri.Instance != null)
        {
            InvokeRepeating("SpawnBrick", 1f, Pistelaskuri.Instance.spawnVali);
        }

        //Pistelaskuri.Instance.spawnVali = 0.1f;

    }



    void SpawnBrick()

    {

        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );

   
        
        
        Instantiate(tiiliPrefab, spawnPos, Quaternion.identity);



        //    if (numero >= 10)
        //    {

        //        if (spawnInterval >= 0.1f)
        //        {
        //            spawnInterval -= 0.1f;

        //            numero -= 10;
        //        }

        //        else
        //        {
        //            numero -= 10;
        //        }
        //    }
        //    else
        //    {
        //       numero += 1;
        //    }
    }

}
