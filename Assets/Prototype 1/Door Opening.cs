using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class DoorOpening : MonoBehaviour
{
    public bool valid;
    public RaycastHit hitInfo;
    public Vector3 hitPoint;
    public Vector3 hitNormal;
    public bool isLeft;
    public float timeValid = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valid = false;
        isLeft = false; 
    }

    // Update is called once per frame
    void Update()
    {
        timeValid -= Time.deltaTime;


    }
    public void FixedUpdate()
    {
        if(Keyboard.current.aKey.isPressed)
        {
            isLeft = true;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            isLeft = false;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame && isLeft)
        {
            valid = Physics2D.Raycast(transform.position, Vector2.left, 3f, LayerMask.GetMask("Door"));
            Debug.DrawRay(transform.position, Vector2.left * 3f, Color.purple, 2f);
            timeValid = 3f;
        }
        else if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            valid = Physics2D.Raycast(transform.position, Vector2.right, LayerMask.GetMask("Door"));
            Debug.DrawRay(transform.position, Vector2.right * 3f, Color.purple, 2f);
            timeValid = 3f;
        }


        if (valid && timeValid > 0)
        {
            Debug.Log("hit found" + hitInfo.point);
            Debug.DrawRay(hitInfo.point, hitInfo.normal, Color.cyan, 2f);
            Destroy(gameObject);
        }
        
        

        hitPoint = hitInfo.point;
        hitNormal = hitInfo.normal;

    }
}


