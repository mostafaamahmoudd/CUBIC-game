using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Forwardforce = 500f;
    public float sideForce = 250f;

    void FixedUpdate ()
    {
        rb.AddForce(0, 0, Forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -0.5f)
        {
            FindObjectOfType<gameMAnager>().EndGame();
        }

    }
}
