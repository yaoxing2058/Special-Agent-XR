using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    private AudioSource knifeSound;

    // Start is called before the first frame update
    void Start()
    {
        knifeSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void OnTriggerEnter(Collider other)
    {
        knifeSound.PlayOneShot(knifeSound.clip);

        if (other.tag == "Zombie") {
            var monster = other.GetComponent<Monster>();
            Debug.Log("Hit!");
            monster.Hurt(20);
        }
    }
}
