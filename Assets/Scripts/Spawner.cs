using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Cube1prefab;


    public Vector3 center;
    public Vector3 size;

    private int sumAmount = 1;

    void Start()
    {

        Cube1prefab = GameObject.FindWithTag("Cube1");

        for (int i = 0; i < sumAmount; i++)
        {
            SpawnItems();
        }

    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }


    public void SpawnItems()
    {
        Destroy(Cube1prefab);

        Vector3 pos = center + new Vector3(Random.Range(-size.x/2 , size.x/2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

            Instantiate(Cube1prefab, pos, Quaternion.identity);
        
    }



}