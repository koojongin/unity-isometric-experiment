using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindAndAttack : MonoBehaviour
{
    public GameObject coreObjGameObject;
    private float speed = 1.0f;
    private NavMeshAgent agent = null;
    private bool isStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        // coreObjGameObject = GameObject.FindGameObjectWithTag("Core").gameObject;
        // agent = GetComponent<NavMeshAgent>();
        // agent.destination = coreObjGameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted == false && coreObjGameObject)
        {
            agent = GetComponent<NavMeshAgent>();
            agent.destination = coreObjGameObject.transform.position;
            isStarted = true;
        }

        if (!coreObjGameObject)
            coreObjGameObject = GameObject.FindGameObjectWithTag("Core").gameObject;
        // float step = speed * Time.deltaTime;
        // transform.position = Vector2.MoveTowards(transform.position, coreObjGameObject.transform.position, step);
    }
}
