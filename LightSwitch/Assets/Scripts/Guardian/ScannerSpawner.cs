using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnInterval = 10f;
    public float destroyDelais = 5f;
    private float timer = 0f;

     void Update()
    {
    timer += Time.deltaTime;

    if(timer >= spawnInterval)
    {
     GameObject spawnedObjet = Instantiate(objectPrefab , transform.position , Quaternion.identity);
     Destroy(spawnedObjet , destroyDelais);   
     timer = 0f;
    }    


    }
}
