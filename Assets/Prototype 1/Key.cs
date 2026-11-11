using UnityEngine;

public class Key : MonoBehaviour
{

    MGameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GetComponent<MGameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Touch");
            //gm.objective = true;
            Destroy(this.gameObject);
        }
    }
}
