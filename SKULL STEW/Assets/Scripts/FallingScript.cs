using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class FallingScript : MonoBehaviour
{
    //variables go here

    public Vector3 startPos;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (transform.position.y < -1.5f)
        {
            transform.position = startPos;
            rb.velocity = Vector3.zero;
        } */
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Reset")
        {
            ResetPos();
        }
    }

    public void ResetPos()
    {
        transform.position = startPos;
        rb.velocity = Vector3.zero;
    }
}
