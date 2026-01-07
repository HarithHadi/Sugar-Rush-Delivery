using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject[] obstacle;
    public GameObject scoreZone;

    [Header("Settings")]
    private float[] lanes = { -6f, -3.25f, -0.1f };
    public int obstacleCount = 10;
    private int[] zPos = {0, 30, 60, 90, 120, 150, 180 };


    void Start()
    {
        SpawnThings();
    }

    public void SpawnThings()
    {
        //copy of the lanes
        List<float> availableLanes = new List<float>(lanes);

        foreach (int Zcurr in zPos) 
        {
            int XposIndex = Random.Range(0, availableLanes.Count); // 0-3 random
            int currZpos = Zcurr; 

            Vector3 spawnPos = new Vector3(availableLanes[XposIndex], 0 ,currZpos);

            

            int prefabIndex = Random.Range(0, obstacle.Length);
            GameObject obj = Instantiate(obstacle[prefabIndex], transform);
            obj.transform.localPosition = spawnPos;
        }
        
    }

}