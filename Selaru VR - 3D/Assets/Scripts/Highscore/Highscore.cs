using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GAME_MODE
{
    FIRE_TRAINING, TOUR
}

public class Highscore : MonoBehaviour
{

    public float score;

    public GAME_MODE gameMode;

    private void Start()
    {
        LoadHighscore();
    }

    public void SaveHighscore(float newScore)
    {
        if (PlayerPrefs.GetFloat(gameMode.ToString()) > 0)
        {
            if (newScore < PlayerPrefs.GetFloat(gameMode.ToString()))
            {
                PlayerPrefs.SetFloat(gameMode.ToString(), newScore);
                Debug.Log("saved " + gameMode.ToString() + " score " + (newScore / 60).ToString("00") + ":" + (newScore % 60).ToString("00"));
                LoadHighscore();
            }
        }
    }

    public void LoadHighscore()
    {
        score = PlayerPrefs.GetFloat(gameMode.ToString());
        Debug.Log("loaded " + gameMode.ToString() + " score " + (score / 60).ToString("00") + ":" + (score % 60).ToString("00"));
    }
}
