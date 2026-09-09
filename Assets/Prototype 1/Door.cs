using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void DoorOpen(float location)                                                                                                                                                        
    {
        transform.position = new Vector2(location, location);
    }
}
