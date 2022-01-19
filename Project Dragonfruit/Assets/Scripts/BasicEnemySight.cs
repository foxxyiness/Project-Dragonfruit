using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemySight : MonoBehaviour
{
    public bool seen = false;
    private GameObject target;
    public float PlrVisnRange;
    public float StdVisnRange;
    public NavMeshAgent pathFinding;
    public GameObject eyes;
    public GameObject Body;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(eyes.transform.position, this.transform.forward * PlrVisnRange);
        Ray Ray2 = new Ray(eyes.transform.position, this.transform.forward * StdVisnRange);
        UnityEngine.Debug.DrawRay(ray.origin, ray.direction * PlrVisnRange, Color.red);

        RaycastHit hit1;
        RaycastHit hit2;
        if (Physics.Raycast(ray, out hit1) && (hit1.transform.tag == "Player"))
        {
            //UnityEngine.Debug.Log("I see something");
            seen = true;
            target = hit1.transform.gameObject;
        }
        else if (Physics.Raycast(Ray2, out hit2) && (hit2.transform.tag == "Cover"))
        {
            //UnityEngine.Debug.Log("It went away");
            seen = false;
            target = hit1.transform.gameObject;
        }


        if (StressManagement.Instance.strsslvl < 25 )
        {

        }
        if (StressManagement.Instance.strsslvl >= 25 || StressManagement.Instance.strsslvl <= 50)
        {

        }
        if (StressManagement.Instance.strsslvl >= 50 || StressManagement.Instance.strsslvl <= 75)
        {

        }
        if (StressManagement.Instance.strsslvl >= 75 || StressManagement.Instance.strsslvl <= 99)
        {
            
        }
        if (StressManagement.Instance.strsslvl == 100)
        {

        }
        if (seen == true && StressManagement.Instance.strsslvl != 100)
        {
            Vector3 loc = target.transform.position;
            loc.z = 0;
            UnityEngine.Debug.Log(loc);
            pathFinding.SetDestination(loc);
            StressManagement.Instance.strsslvl += 1;
        }
        if (seen == false)
        {

        }
        
    }

}
