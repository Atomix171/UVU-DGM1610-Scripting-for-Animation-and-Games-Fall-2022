using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class Enemy : MonoBehaviour
{
    public int curHp, maxHp, scoreToGive;
    public float moveSpeed, attackRange, yPathOffset;
    private List<Vector3> path;
    
    private GameObject target;
    
    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        //Get the Components
        //weapon = GetComponent<Weapon>();
        target = FindObjectOfType<PlayerController>().gameObject;

        player = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("UpdatePath", 0.0f, 0.5f);

        curHp = maxHp;
    }

    void UpdatePath()
    {
        // Calculate a path to the target
        NavMeshPath navMeshPath = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, target.transform.position, NavMesh.AllAreas, navMeshPath);

        path = navMeshPath.corners.ToList();
    }

    void ChaseTarget()
    {
        if(path.Count == 0)
            return;

        //Move towards the closest path
        transform.position = Vector3.MoveTowards(transform.position, path[0] + new Vector3(0,yPathOffset,0), moveSpeed * Time.deltaTime);

        if(transform.position == path[0] + new Vector3(0, yPathOffset, 0))
            path.RemoveAt(0);
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;
        
        if(curHp <=0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("You Died! You Lose!");
    }

    void Update()
    {
        //Look at the target
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.x,dir.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * angle;

        
        // Callate the distance between the enemy and the player
        float dist = Vector3.Distance(transform.position, target.transform.position);
        //If within attackrange shoot at player
        if(dist <= attackRange)
        {
            player.TakeDamage(1);
        }
        else
        {
            ChaseTarget();
        }
    }
}
