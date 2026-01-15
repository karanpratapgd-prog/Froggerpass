using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public float spawnDelay = 0.85f;

    public GameObject carPrefab;

    private float nextTimeToSpawn;

    // Update is called once per frame
    void Update()
    {

        if (nextTimeToSpawn <= Time.time)
        {

            SpawnCar();

            nextTimeToSpawn = Time.time + spawnDelay;

        }

    }

    void SpawnCar()
    {
        Instantiate(carPrefab, transform.position, transform.rotation);
    }

}