using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target_Scr : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;
    public Transform[] targets;
    int targetIndex = 0;
    float reachDistance = 0.95f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        float distance2Target = Vector3.Distance(transform.position, targets[targetIndex].position);
        agent.destination = targets[targetIndex].position;
        Debug.Log(distance2Target);
        if (distance2Target > reachDistance)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            targetIndex++;
            anim.SetBool("Walk", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
