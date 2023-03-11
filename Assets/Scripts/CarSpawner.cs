using UnityEngine;

public class CarSpawner : MonoBehaviour {

	private float spawnDelay = 0.3f;

	public GameObject car;

	public Transform[] spawnPoints;

	float nextTimeToSpawn = 0f;

	public float newSpawnRate;

	void Update ()
	{
		newSpawnRate = carSettings.spawnRateValue / 2 / 10;
		spawnDelay = newSpawnRate;

		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		Instantiate(car, spawnPoint.position, spawnPoint.rotation);
	}

}
