using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [Header ("Prefabs")]
    public GameObject[] obstacle;

    [Header("Settings")]
    public float[] lanes = { -6f, -3.25f, -0.1f };
    public int obstacleCount = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnThings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnThings() 
    {
        List<float> availableLanes = new List<float>(lanes);

        int maxObstacles = lanes.Length - 1;
        int spawnCount = Mathf.Min(obstacleCount, maxObstacles);

        for (int i = 0; i < obstacleCount; i++) 
        {
            int laneIndex = Random.Range(0, availableLanes.Count);
            float xPos = availableLanes[laneIndex];
            availableLanes.RemoveAt(laneIndex);

            float randomZ = Random.Range(0, 160);

            Vector3 localSpawnPos = new Vector3(xPos, 0, randomZ);
            int prefabIndex = Random.Range(0, obstacle.Length);
            GameObject obj = Instantiate(obstacle[prefabIndex], transform);

            //to make the obstacle move with the map
            obj.transform.localPosition = localSpawnPos;
        }
        
    }
    
}
