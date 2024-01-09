using UnityEngine;
using UnityEngine.AI;

public class PlayerPatrol : MonoBehaviour {
    public Transform routeFather;
    private int indexChildren;
    private Vector3 destination;

    private void Start () {
        destination = routeFather.GetChild(indexChildren).position;
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }

    private void Update() {
        if (Vector3.Distance(transform.position, destination) < 2.5f) {
            indexChildren++;
            if (indexChildren >= routeFather.childCount) indexChildren = 0;
            destination = routeFather.GetChild(indexChildren).position;
            GetComponent<NavMeshAgent>().SetDestination(destination);
        }
    }

    // Bounded Random Route

    // Calculate a random point on the navMesh
}
