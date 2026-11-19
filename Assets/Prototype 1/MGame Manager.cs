using UnityEngine;
using UnityEngine.SceneManagement;

public class MGameManager : MonoBehaviour
{
    public bool objective;
    public static MGameManager Instance;
    public int sceneIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
      //private void Awake()
  //{
        //if(Instance != null)   
        //{
         //   Destroy(gameObject);
         //   return;
       // }
       // Instance = this;
 // }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
