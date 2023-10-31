using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public GameObject expolsion;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(expolsion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
