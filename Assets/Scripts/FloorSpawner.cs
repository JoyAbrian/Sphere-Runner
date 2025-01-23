using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject floorPrefab;
    public int initialFloorCount = 4;
    public float floorLength = 10f;
    public ObstacleSpawner obstacleSpawner;
    private void Start()
    {
        for (int i = 0; i < initialFloorCount; i++)
        {
            SpawnFloor(i * floorLength);
        }
    }

    private void Update()
    {
        if (transform.childCount < initialFloorCount)
        {
            SpawnFloor(FindFarthestFloorPosition() + floorLength);
        }
    }

    private void SpawnFloor(float spawnZ)
    {
        Vector3 spawnPosition = new Vector3(0, 0, spawnZ);
        GameObject floor = Instantiate(floorPrefab, spawnPosition, Quaternion.identity);
        floor.transform.SetParent(transform);

        if (obstacleSpawner != null)
        {
            obstacleSpawner.SpawnObstacles(floor.transform);
        }
    }

    private float FindFarthestFloorPosition()
    {
        float farthestZ = 0f;

        foreach (Transform child in transform)
        {
            if (child.position.z > farthestZ)
            {
                farthestZ = child.position.z;
            }
        }

        return farthestZ;
    }
}