using UnityEngine;
using UnityEngine.SceneManagement;

public class BgmManager : MonoBehaviour
{

    [Header("BGM Menu")]
    [SerializeField] bool isUsingBgm;
    [SerializeField] AudioClip bgm;
    [SerializeField] bool isStopInCertainScene;
    [SerializeField] string[] stopMusicInTheseScenes;

    string currentScene;
    bool currentIsMusicScene = true;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] thisObj = GameObject.FindGameObjectsWithTag("BGM");
        if (thisObj.Length > 1)
        {
            Destroy(gameObject);
        }
            DontDestroyOnLoad(gameObject);
            if (isUsingBgm)
            {
                GetComponent<AudioSource>().clip = bgm;
            }
            currentScene = SceneManager.GetActiveScene().name;
    }

    private void FixedUpdate()
    {
        if (isStopInCertainScene)
        {
            CheckBgm();
        }
    }

    private void CheckBgm()
    {
        if (PlayerPrefs.GetInt("audioStatus") == 0)
        {
            if (currentScene != SceneManager.GetActiveScene().name)
            {
                currentScene = SceneManager.GetActiveScene().name;

                for (int i = 0; i < stopMusicInTheseScenes.Length; i++)
                {
                    if (currentScene == stopMusicInTheseScenes[i])
                    {
                        GetComponent<AudioSource>().Stop();
                        currentIsMusicScene = false;
                        break;
                    }
                    else
                    {
                        currentIsMusicScene = true;
                    }
                }

                if (currentIsMusicScene && !GetComponent<AudioSource>().isPlaying)
                {
                    GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
