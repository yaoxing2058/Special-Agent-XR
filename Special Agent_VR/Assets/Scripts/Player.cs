using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public enum State
    {
        ALIVE, DEAD
    }

    public State playerState = State.ALIVE;

    public int maxHealth;

    public int health;

    public int damage;
    public Monster _monster;
    public Tank _tank;

    

    void Start()
    {
        health = maxHealth;
        //_monster = gameobject.getcomponent<Monster>;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hurt(int damage)
    {
        if (playerState == State.ALIVE)
        {
            health -= _monster.damage;
            Debug.Log(health);
            Debug.Log(_monster.damage);
            if (health <= 0)
            {
                Debug.Log("in here");
                Die();
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Missile")
        {
            Debug.Log("Hit!");
            health -= _tank.damage;
            if (health <= 0)
            {
                Debug.Log("in here");
                Die();
            }

        }
    }

        void Die()
    {
        playerState = State.DEAD;
        SceneManager.LoadScene("Project");
    }
}
