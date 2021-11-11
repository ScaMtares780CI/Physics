using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float speed = 4;

    void LateUpdate()
{
        float x = Input.GetAxis("Mouse X") * 2;
        float y = -Input.GetAxis("Mouse Y");
        // vertical tilting
        float yClamped = transform.eulerAngles.x + y;
        transform.rotation = Quaternion.Euler(yClamped, transform.eulerAngles.y, transform.eulerAngles.z);
        // horizontal orbiting
        transform.RotateAround(new Vector3(0, 3, 0), Vector3.up, x);
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody projectile = Instantiate(projectile, transform.position, transform.rotation);
            projectile.velocity = transform.forward * speed;
        }
    }

}
