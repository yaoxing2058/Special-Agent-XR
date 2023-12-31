using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleEffects : MonoBehaviour
{
    private ParticleSystem muzzleSmoke;

    // Start is called before the first frame update
    void Start()
    {
        muzzleSmoke = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("RightTrigger")) {
            muzzleSmoke.Emit(3);
        }
    }
}
