using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class DoorOpening : MonoBehaviour
{
    public bool valid;
    public RaycastHit2D hitInfo;
    public Vector3 hitPoint;
    public Vector3 hitNormal;
    public bool isLeft;
    public float timeValid = 3;
    public Door doorCode;
    public LayerMask Mask;
  public GameObject gameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorCode = GetComponent<Door>();
        valid = false;
        isLeft = false; 
    }

    // Update is called once per frame
    void Update()
    {

        if (timeValid > 0)
        {
            timeValid -= Time.deltaTime;

        }
        else
        {
        timeValid = 0;  
        }

        if (Keyboard.current.aKey.isPressed)
        {
            isLeft = true;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            isLeft = false;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame && isLeft)
        {
            hitInfo = Physics2D.Raycast(transform.position, Vector2.left, 3f, Mask);
            Debug.DrawRay(transform.position, Vector2.left * 3f, Color.purple, 2f);
            timeValid = 3f;
        }
        else if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            hitInfo = Physics2D.Raycast(transform.position, Vector2.right, Mask);
            Debug.DrawRay(transform.position, Vector2.right * 3f, Color.purple, 2f);
            timeValid = 3f;
           
        }
       

        if (hitInfo && timeValid > 0)
        {
            if (hitInfo.collider.CompareTag("Door"))
            {
                hitInfo.collider.gameObject.SetActive(false);
            }
            Debug.Log("hit found" + hitInfo);
            Debug.DrawRay(hitInfo.point, hitInfo.normal, Color.cyan, .5f);
            
        }



        hitPoint = hitInfo.point;
        hitNormal = hitInfo.normal;
    }
    
}


