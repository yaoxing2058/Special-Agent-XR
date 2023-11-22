using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunADS : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1)) {
            anim.Play("ADS On");
        }
        if (Input.GetKeyUp(KeyCode.Mouse1)) {
            anim.Play("ADS Off");
        }
    }
}
