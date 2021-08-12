using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFire : MonoBehaviour
{
    [SerializeField] GameObject fire;
    [SerializeField] List<GameObject> fireSpawnPos;
    [SerializeField] private FireChecker fireChecker;

    // Start is called before the first frame update
    void Start()
    {
        RandomSpawn(Random.Range(1, 3));
    }

    void RandomSpawn(int spawnNumber)
    {
        FireData.count = spawnNumber;
        for (int i = 0; i < spawnNumber; i++)
        {
            int rand = Random.Range(0, fireSpawnPos.Count);
            Instantiate(fire, fireSpawnPos[rand].transform);
            fireSpawnPos.RemoveAt(rand);
        }
    }
}
