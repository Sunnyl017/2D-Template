using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
public static Gamemanager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
  //private void Awake()
  //{
        //if(Instance != null)   
        //{
         //   Destroy(gameObject);
         //   return;
       // }
       // Instance = this;
 // }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
