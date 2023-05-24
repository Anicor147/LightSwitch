using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerSpawner : MonoBehaviour
{
    public GameObject objectWhiteScanner;
    public GameObject objectDarkScanner;
    public float spawnInterval = 10f;
    public float destroyDelais = 5f;
    private float timer = 0f;
    bool scannerisWhite= false;
     void Update()
    {
    timer += Time.deltaTime;

    if(timer >= spawnInterval && !scannerisWhite)
    {
     GameObject spawnedObjet = Instantiate(objectWhiteScanner , transform.position , Quaternion.identity);
     Destroy(spawnedObjet , destroyDelais);   
     timer = 0f;
     scannerisWhite = true;
    }
    else if(timer >= spawnInterval && scannerisWhite)
    {
        GameObject spawnedObjet = Instantiate(objectDarkScanner , transform.position , Quaternion.identity);
     Destroy(spawnedObjet , destroyDelais);   
     timer = 0f;
     scannerisWhite = false;
    }


    }



}
