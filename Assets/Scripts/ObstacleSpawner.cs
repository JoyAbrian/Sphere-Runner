using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject wideObstaclePrefab; // Prefab for the wide obstacle
    public int obstaclesPerGroup = 3;
    public float minX = -1.25f;
    public float maxX = 1.25f;
    public float minZOffset = 2f;
    public float maxZOffset = 8f;

    public void SpawnObstacles(Transform floor)
    {
        for (int i = 0; i < obstaclesPerGroup; i++)
        {
            float randomX = Random.Range(minX, maxX);
            float randomZ = Random.Range(minZOffset, maxZOffset);
            Vector3 spawnPosition = floor.position + new Vector3(randomX, 0, randomZ);

            GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);

            obstacle.transform.SetParent(floor);
        }

        // Spawn a wide obstacle in the middle of the floor
        SpawnWideObstacle(floor);
    }

    private void SpawnWideObstacle(Transform floor)
    {
        // Calculate the spawn position for the wide obstacle
        float wideObstacleZ = Random.Range(minZOffset, maxZOffset);
        Vector3 spawnPosition = floor.position + new Vector3(0, 0, wideObstacleZ);

        // Instantiate the wide obstacle
        GameObject wideObstacle = Instantiate(wideObstaclePrefab, spawnPosition, Quaternion.identity);

        // Parent the wide obstacle to the floor
        wideObstacle.transform.SetParent(floor);
    }
}
