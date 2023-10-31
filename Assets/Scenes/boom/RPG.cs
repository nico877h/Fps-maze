using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody rocket;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clonnedRocket;
            clonnedRocket = Instantiate(rocket, transform.position, transform.rotation);

            clonnedRocket.velocity = transform.TransformDirection(Vector3.forward * 20f);
        }
    }
}
