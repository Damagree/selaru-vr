using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClassChallenge : MonoBehaviour
{

    [SerializeField] LevelManager levelManager;
    [SerializeField] string[] challengeScenes;

    public void RandomChallenge()
    {
        int rand = Random.Range(0, challengeScenes.Length-1);
        levelManager.LoadSceneByName(challengeScenes[rand]);
    }
}
