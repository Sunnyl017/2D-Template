using System.Threading;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject gameObject;
    private bool isActive;
    public float respawnTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void DoorRespawn()                                                                                                                                                        
    {
       if(this.gameObject.activeSelf == false) 
        {
            respawnTimer = 3;

        }
        if (respawnTimer > 0)
        {
            respawnTimer -= Time.deltaTime;
        }
        else
        {
            respawnTimer = 0;
            this.gameObject.SetActive(true);
        }


    }
}
