using UnityEngine;
using UnityEngine.AI;

public class PlayerRandomRoute: MonoBehaviour {
    public Transform routeFather;
    private int indexChildren;
    private Vector3 destination;

    private void Start () {
        destination = routeFather.GetChild(indexChildren).position;
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }

    private void Update() {
        if (Vector3.Distance(transform.position, destination) < 2.5f) {
            indexChildren = Random.Range(0, routeFather.childCount);
            destination = routeFather.GetChild(indexChildren).position;
            GetComponent<NavMeshAgent>().SetDestination(destination);
        }
    }
}
