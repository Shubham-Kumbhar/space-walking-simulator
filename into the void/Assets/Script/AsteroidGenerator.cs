using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    public float spawnRange;
    public float amountToSpawn;
    private Vector3 spawnPoint;
    public GameObject asteroid, asteroid2, asteroid3, asteroid4, asteroid5;
    public float startSafeRange;
    private List<GameObject> objectsToPlace = new List<GameObject>();

    // Start is called before the first frame update
    public void Start()
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            PickSpawnPoint();
            randomobject();

            //pick new spawn point if too close to player start
            while (Vector3.Distance(spawnPoint, Vector3.zero) < startSafeRange)
            {
                PickSpawnPoint();
            }

            objectsToPlace.Add(Instantiate(asteroid, spawnPoint, Quaternion.Euler(Random.Range(0f,360f), Random.Range(0f, 360f), Random.Range(0f, 360f))));
            objectsToPlace[i].transform.parent = this.transform;
        }

    }
    void randomobject() 
    {
        int a;
        a = Random.Range(0, 4);
        if (a==1)
        {
            asteroid = asteroid2;
            Debug.Log("1");
        }
        else if(a==2)
        {
            asteroid = asteroid3;
        }
        else if (a == 3)
        {
            asteroid = asteroid4;
        }
        else if(a==4)
        {
            asteroid = asteroid5;
            Debug.Log("4");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickSpawnPoint()
    {
        spawnPoint = new Vector3(
            Random.Range(-1f,1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f));

        if(spawnPoint.magnitude > 1)
        {
            spawnPoint.Normalize();
        }

        spawnPoint *= spawnRange;
    }
}

