using UnityEngine;
using UnityEngine.UI;

public class AudioMute : MonoBehaviour
{
    public enum AUDIO_STATUS { UNMUTED, MUTED }

    [Header("Setting Menu")]
    [SerializeField] bool usingIcon;
    [SerializeField] Image soundIcon;
    [SerializeField] Sprite unmutedSprite;
    [SerializeField] Sprite mutedSprite;

    GameObject[] audioObjects;
    GameObject[] bgmObjects;

    public int audioStatus;

    private void Start()
    {
        audioStatus = PlayerPrefs.GetInt("audioStatus");
        audioObjects = GameObject.FindGameObjectsWithTag("Audio");
        bgmObjects = GameObject.FindGameObjectsWithTag("BGM");
        if (audioStatus == (int)AUDIO_STATUS.MUTED)
        {
            foreach (GameObject item in audioObjects)
            {
                if (item.GetComponent<AudioSource>())
                    item.GetComponent<AudioSource>().Stop();
            }

            foreach (GameObject item in bgmObjects)
            {
                if (item != null)
                    item.GetComponent<AudioSource>().Stop();
            }
        }
        SetIcon();
    }

    public void SetAudioMute()
    {
        if (audioStatus == ((int)AUDIO_STATUS.MUTED))
        {
            PlayerPrefs.SetInt("audioStatus", (int)AUDIO_STATUS.UNMUTED);
            audioStatus = (int)AUDIO_STATUS.UNMUTED;
            foreach (GameObject item in audioObjects)
            {
                if (item.GetComponent<AudioSource>())
                {
                    item.GetComponent<AudioSource>().Play();
                }
            }
            foreach (GameObject item in bgmObjects)
            {
                if (item != null)
                {
                    item.GetComponent<AudioSource>().Play();
                }
            }
        }
        else
        {
            PlayerPrefs.SetInt("audioStatus", (int)AUDIO_STATUS.MUTED);
            audioStatus = (int)AUDIO_STATUS.MUTED;
            foreach (GameObject item in audioObjects)
            {
                if (item.GetComponent<AudioSource>())
                {
                    item.GetComponent<AudioSource>().Stop();
                }
            }
            foreach (GameObject item in bgmObjects)
            {
                if (item != null)
                    item.GetComponent<AudioSource>().Stop();
            }
        }
        SetIcon();
    }

    private void SetIcon()
    {
        if (usingIcon)
        {
            if (audioStatus == (int)AUDIO_STATUS.MUTED)
            {
                soundIcon.sprite = mutedSprite;
            }
            else
            {
                soundIcon.sprite = unmutedSprite;
            }
            
        }
    }

}
