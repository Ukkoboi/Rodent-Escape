using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public int amount;
    public float minSize;
    public float maxSize;
    public GameObject block;
    //public GameObject block1;
    public Collider ground;
    void Start()
    {
        Vector3 minPoint = ground.bounds.min;
        Vector3 maxPoint = ground.bounds.max;

        //int spruce = amount / 2;
        //int leaftree = amount / 2;

        for (int i = 0; i < amount; i++)
        {
            float randomx = Random.Range(minPoint.x, maxPoint.x);
            float randomz = Random.Range(minPoint.z, maxPoint.z);
            float randomSize = Random.Range(minSize, maxSize);

            Vector3 position = new Vector3(randomx, maxPoint.y, randomz);
            GameObject spawnedBlock = Instantiate(block, position, new Quaternion(), transform);
            spawnedBlock.transform.localScale *= randomSize;
        }

        // Ota tämä käyttöön kun teet lehtipuun
        /*
        for (int i = 0; i < leaftree; i++)
        {
            float randomx = Random.Range(minPoint.x, maxPoint.x);
            float randomz = Random.Range(minPoint.z, maxPoint.z);
            float randomSize = Random.Range(minSize, maxSize);

            Vector3 position = new Vector3(randomx, maxPoint.y, randomz);
            GameObject spawnedBlock1 = Instantiate(block1, position, new Quaternion(), transform);
            spawnedBlock1.transform.localScale *= randomSize;
        }
        */
    }

}
