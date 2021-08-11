using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeUI : MonoBehaviour
{

    [SerializeField, Tooltip("Time Text TMP")] private TextMeshProUGUI textTime;
    [SerializeField, Tooltip("Score Time Text TMP")] private TextMeshProUGUI textScoreTime;

    public float currentTime;

    public bool isFinished;
    public Highscore highscore;

    private void Update()
    {
        if (!isFinished)
        {
            currentTime += Time.deltaTime;
            UpdateTimeText();
        }
    }

    public void Finished(bool isFinish)
    {
        highscore.SaveHighscore(currentTime);
        isFinished = isFinish;
    }

    private void UpdateTimeText()
    {
        textTime.text = ((int)currentTime / 60).ToString("00") + ":" + ((int)currentTime % 60).ToString("00");
    }

    public void UpdateTimeScore()
    {
        textScoreTime.text = ((int)currentTime / 60).ToString("00") + ":" + ((int)currentTime % 60).ToString("00");
    }

}
