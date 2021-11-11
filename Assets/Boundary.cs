using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public GameObject explosion;

    void OnCollisionEnter(){
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
