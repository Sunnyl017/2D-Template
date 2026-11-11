using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public GameObject gameObject;
    NavMeshAgent navMesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        navMesh = GetComponent<NavMeshAgent>();
        navMesh.updateRotation = false;
        navMesh.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        navMesh.SetDestination(gameObject.transform.position);
    }
}
