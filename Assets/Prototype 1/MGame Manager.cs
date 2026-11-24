using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UIElements;

using TMPro;
public class MGameManager : MonoBehaviour
{
    public bool objective;
    public static MGameManager Instance;
    public bool isMuted = false;
    public float volume = 0.5f;
    public Slider volumeSlider;
    public TextMeshProUGUI volumeText;
    public List<Scene> list;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objective = false;
    }

    //private void Awake()
    //{
    //    if (Instance != null)
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }
    //    Instance = this;
    //    volumeSlider.value = volume;

    //}

    public void ToggleMute(bool mute)
    {
        AudioListener.volume = mute ? 0 : 1;

        isMuted = mute;
    }


    public void SetVolume(float desiredVolume)
    {
        volume = desiredVolume;
        volumeText.text = $"Volume: {(desiredVolume * 100).ToString("F0")}%";
    }



    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(LoadSceneAsync(sceneIndex));
    }

    private IEnumerator LoadSceneAsync(int sceneIndex)
    {
        var loadOperation = SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Additive);
        while (!loadOperation.isDone)
        {
            Debug.Log("LoadingScene: " + loadOperation.progress);
            yield return null;
        }
        Scene newlyLoadedScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
        SceneManager.SetActiveScene(newlyLoadedScene);
    }

}
