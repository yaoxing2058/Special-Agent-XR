using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Trigger : MonoBehaviour
{
    private Animator anim;
    private AudioSource fire;
    private AudioClip gunSound;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        fire = gameObject.GetComponent<AudioSource>();
        gunSound = fire.clip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("RightTrigger")) {
            anim.SetTrigger("Active");
            fire.PlayOneShot(gunSound);
        }
        
    }
}
