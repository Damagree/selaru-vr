using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum GAME_MODE
{
    FIRE_TRAINING, TOUR
}

public class Highscore : MonoBehaviour
{

    public float score;

    public TextMeshProUGUI textHighscore;

    public GAME_MODE gameMode;

    private void Start()
    {
        //PlayerPrefs.SetFloat(gameMode.ToString(), 1000);
        LoadHighscore();
        if (textHighscore != null)
        {
            textHighscore.text = (score / 60).ToString("00") + ":" + (score % 60).ToString("00");
        }
    }

    public void SaveHighscore(float newScore)
    {
        if (PlayerPrefs.GetFloat(gameMode.ToString()) > 0)
        {
            if (newScore < PlayerPrefs.GetFloat(gameMode.ToString()))
            {
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
