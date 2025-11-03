using UnityEngine;
using UnityEngine.AI;

public class FollowPlayerAtDistance : MonoBehaviour
{
    [Header("References")]
    public Transform player;           // Player to follow
    public NavMeshAgent agent;
    public Animator animation;// The NavMeshAgent component

    [Header("Follow Settings")]
    public float followDistance = 3f;  // Desired distance from the player
    public float updateRate = 0.2f;    // How often to update pathfinding

    private float nextUpdateTime = 0f;

    void Start()
    {
        if (agent == null)
            agent = GetComponent<NavMeshAgent>();

        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player")?.transform;

        if(animation == null)
            animation = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (player == null || agent == null)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        if(distance > followDistance)
        {
            agent.SetDestination(player.position);
            agent.isStopped = false;
        }
        else
        {
            agent.isStopped = true;
        }

        float speed = agent.velocity.magnitude;
        animation.SetFloat("Speed", speed);

    }

}
