using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemySight : MonoBehaviour
{
    public bool seen = false;
    private GameObject target;
    public float visionRange;
    public NavMeshAgent pathFinding;
    public GameObject eyes;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!seen)
        {
            Ray ray = new Ray(eyes.transform.position, this.transform.forward * visionRange);
            UnityEngine.Debug.DrawRay(ray.origin, ray.direction * visionRange, Color.red);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && (hit.transform.tag == "Player"))
            {
                UnityEngine.Debug.Log("I see something");
                seen = true;
                target = hit.transform.gameObject;
            }
        }
        else
        {
            Vector3 loc = target.transform.position;
            loc.z = 0;
            pathFinding.SetDestination(loc);
        }
    }

}
