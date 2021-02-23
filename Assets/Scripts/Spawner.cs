using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Treasure_1_prefab;

    public Terrain Worldterrain;
    public LayerMask TerrainLayer;
    public static float TerrainLeft, TerrainRight, TerrainTop, TerrainBottom, TerrainWidth, TerrainLength, TerrainHeight;
    public Vector3 center;
    public Vector3 size;

    public void Awake()
    {
        TerrainLeft = Worldterrain.transform.position.x+25;
        TerrainBottom = Worldterrain.transform.position.z+25;
        TerrainWidth = Worldterrain.terrainData.size.x-50;
        TerrainLength = Worldterrain.terrainData.size.z-50;
        TerrainHeight = Worldterrain.terrainData.size.y;
        TerrainRight = TerrainLeft + TerrainWidth;
        TerrainTop = TerrainBottom + TerrainLength;

        InstantiateRandomPosition("Prefabs/Treasure_1", 20, 0f);

    }


    void Start()
    {

    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }



    public void InstantiateRandomPosition(string Resource, int Amount, float AddedHeight)
    {

        //Loop throught the amounth of times we want to instantiate
        //Generate random position

        var i = 0;
        float terrainHeight = 0f;
        RaycastHit hit;
        float randomPositionX, randomPositionY, randomPositionZ;
        Vector3 randomPosition = Vector3.zero;

        do{
            i++;
            randomPositionX = Random.Range(TerrainLeft, TerrainRight);  
            randomPositionZ = Random.Range(TerrainBottom, TerrainTop);

            if(Physics.Raycast(new Vector3(randomPositionX, 9999f, randomPositionZ), Vector3.down, out hit, Mathf.Infinity, TerrainLayer))
            {
                terrainHeight = hit.point.y;
            }

            randomPositionY = terrainHeight + AddedHeight;

            randomPosition = new Vector3(randomPositionX, randomPositionY, randomPositionZ);

            Instantiate(Resources.Load(Resource, typeof(GameObject)), randomPosition, Quaternion.identity);
            

        } while (i < Amount);

    }


}