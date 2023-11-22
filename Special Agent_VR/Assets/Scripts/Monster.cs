using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public GameObject player;
    public float attackRange;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    public int maxHealth;
    private int currHealth;
    public int damage;
    public GameObject scriptObject;
    public Player name;
    public enum State {
        ALIVE, DEAD
    }
    public State zombieState = State.ALIVE;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Main Camera");
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        currHealth = maxHealth;
        scriptObject = GameObject.Find("ScriptManager");
        name = scriptObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (zombieState == State.ALIVE) {
            navMeshAgent.SetDestination(player.transform.position);
            Vector3 distanceVector = transform.position - player.transform.position;
            distanceVector.y = 0;
            float distance = distanceVector.magnitude;
            if (distance <= attackRange) {
                Debug.Log("before atk");
                animator.SetBool("Attack", true);
                
            }
            else
            {
                animator.SetBool("Attack", false);
            }
        }
    }
    public void Attack()
    {
        Debug.Log("in atk");
        name.Hurt(damage);
    }
    public void Hurt(int damage)
    {
        if (zombieState == State.ALIVE)
        {
            currHealth -= damage;
            if (currHealth <= 0)
                Die();
        }
    }
    void Die()
    {
        zombieState = State.DEAD;
        navMeshAgent.isStopped = true;
        animator.SetTrigger("Dead");
        navMeshAgent.enabled = false;
        Destroy(gameObject, 5);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit!");
            Hurt(name.damage);

            //Debug.Log("minus10");
            //this.onHit();
        }
    }
}
