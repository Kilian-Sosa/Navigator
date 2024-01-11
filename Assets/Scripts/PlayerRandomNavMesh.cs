using UnityEngine;
using UnityEngine.AI;

public class PlayerRandomNavMesh : MonoBehaviour {
    private Vector3 destination;

    private void Update() {
        if (Vector3.Distance(transform.position, destination) < 2.5f) {
            Vector3 randomPoint = Random.insideUnitSphere * 50;
            NavMeshHit hit;
            NavMesh.SamplePosition(randomPoint, out hit, 50, 1);
            destination = hit.position;
            GetComponent<NavMeshAgent>().SetDestination(destination);
        }
    }
}
