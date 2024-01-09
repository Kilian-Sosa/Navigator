using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    private void Update() {
        if (Input.GetButtonDown("Firel")) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit, 1000))
                GetComponent<NavMeshAgent>().SetDestination(hit.point);
        }
    }
}
