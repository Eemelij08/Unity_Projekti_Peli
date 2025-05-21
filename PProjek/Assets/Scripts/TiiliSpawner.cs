using Unity.VisualScripting;
using UnityEngine;

public class TiiliSpawner : MonoBehaviour
{


    public GameObject BrickPrefab; //  tiili prefab

    public GameObject LBrickPrefab;

    public GameObject LongBrickPrefab;

    public GameObject HoleBrickPrefab;

    public GameObject XBrickPrefab;

    public GameObject TBrickPrefab;


    public float BrickPrefabNumber = 1;

    public float spawnInterval = 2f;       // Kuinka usein pudotetaan tiili

    public Vector2 spawnArea = new Vector2(10f, 10f);

    //hole
    public Vector2 ToinenSpawnArea = new Vector2(9f, 9f);// Pudotusalueen koko

    //long
    


    public float spawnHeight = 10f;        // Pudotuskorkeus



    void Start()

    {
        InvokeRepeating("Spawneri", 1f, spawnInterval);

        //InvokeRepeating("SpawnBrick", 1f, spawnInterval);

        //InvokeRepeating("SpawnLbrick", 1f, spawnInterval);

    }

    /*private void FixedUpdate()
    {
        transform.RotateAround(LBrickPrefab.transform.position, Vector3.up, 20 * Time.deltaTime);
    }*/

    void Spawneri()
    {
        if (BrickPrefabNumber == 1)
        {
            SpawnBrick();
            Debug.Log("11");
        }

        if (BrickPrefabNumber == 2)
        {
            Spawn2Brick();
            Debug.Log("22");
        }

        if (BrickPrefabNumber == 3)
        {
            SpawnLBrick();
            SpawnBrick();
            Debug.Log("33");
        }

        if (BrickPrefabNumber == 4)
        {
            HoleBrick();
            SpawnBrick();
            Debug.Log("44");
        }

        if (BrickPrefabNumber == 5)
        {
            
            SpawnXBrick();
            SpawnTBrick();
            Debug.Log("55");
        }
        if (BrickPrefabNumber == 6)
        {
            HoleBrick();
            SpawnXBrick();
            SpawnTBrick();
            SpawnBrick();
            //TwoHoleBrick();
            Debug.Log("66");
        }
        if (BrickPrefabNumber == 7)
        {
            TwoHoleBrick();

            Debug.Log("77");
        }
        if (BrickPrefabNumber == 8)
        {
            Spawn2Brick();
            
            Debug.Log("88");
        }
    }

    void SpawnBrick()
    {
        Debug.Log("1");
        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );



        Instantiate(BrickPrefab, spawnPos, Quaternion.identity);
        


    }

    void Spawn2Brick()
    {
        Debug.Log("2");
        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );



        Instantiate(BrickPrefab, spawnPos, Quaternion.identity);

        Vector3 spawnPos2 = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );



        Instantiate(BrickPrefab, spawnPos2, Quaternion.identity);
        

    }

    void SpawnLBrick()

    {
        /* int i = 2;

         while (i != 1)
         {
             Vector3 spawnPos2 = new Vector3(

             Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

             spawnHeight,

             Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

         );

             transform.RotateAround(LBrickPrefab.transform.position, Vector3.up, 20 * Time.deltaTime);

             Instantiate(LBrickPrefab, spawnPos2, Quaternion.identity);
             i++;
         }
         Vector3 spawnPos = new Vector3(

             Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

             spawnHeight,

             Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

         );



         Instantiate(LBrickPrefab, spawnPos, Quaternion.identity);
         i++;*/

        Debug.Log("3");
        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );

       

        Instantiate(LBrickPrefab, spawnPos, Quaternion.identity);

    }

    void LongBrick()
    {
        Debug.Log("4");
        Vector3 spawnPos = new Vector3(

            Random.Range(-ToinenSpawnArea.x / 2, ToinenSpawnArea.x / 2),

            spawnHeight,

            Random.Range(-ToinenSpawnArea.y / 2, ToinenSpawnArea.y / 2)

        );



        Instantiate(LongBrickPrefab, spawnPos, Quaternion.identity);



    }

    void HoleBrick()
    {
        Debug.Log("5");
        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );



        Instantiate(HoleBrickPrefab, spawnPos, Quaternion.identity);

       /* Vector3 spawnPos2 = new Vector3(

            Random.Range(-ToinenSpawnArea.x / 2, ToinenSpawnArea.x / 2),

            spawnHeight,

            Random.Range(-ToinenSpawnArea.y / 2, ToinenSpawnArea.y / 2)

        );



        Instantiate(HoleBrickPrefab, spawnPos2, Quaternion.identity);*/



    }
    void TwoHoleBrick()
    {
        Debug.Log("5");
        Vector3 spawnPos = new Vector3(

            Random.Range(-ToinenSpawnArea.x / 2, ToinenSpawnArea.x / 2),

            spawnHeight,

            Random.Range(-ToinenSpawnArea.y / 2, ToinenSpawnArea.y / 2)

        );



        Instantiate(HoleBrickPrefab, spawnPos, Quaternion.identity);

        Vector3 spawnPos2 = new Vector3(

             Random.Range(-ToinenSpawnArea.x / 2, ToinenSpawnArea.x / 2),

             spawnHeight,

             Random.Range(-ToinenSpawnArea.y / 2, ToinenSpawnArea.y / 2)

         );



         Instantiate(HoleBrickPrefab, spawnPos2, Quaternion.identity);



    }

    void SpawnXBrick()
    {
        Debug.Log("1");
        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );



        Instantiate(XBrickPrefab, spawnPos, Quaternion.identity);



    }

    void SpawnTBrick()
    {
        Debug.Log("1");
        Vector3 spawnPos = new Vector3(

            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),

            spawnHeight,

            Random.Range(-spawnArea.y / 2, spawnArea.y / 2)

        );



        Instantiate(TBrickPrefab, spawnPos, Quaternion.identity);



    }

}

