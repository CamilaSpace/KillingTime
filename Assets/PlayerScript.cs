using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    Animator animation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //animation = GetComponentInChildren<Animator>();
        //agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //float speedPercent = agent.velocity.magnitude / agent.speed;
        //animation.SetFloat("Speed", speedPercent);
    }
}
