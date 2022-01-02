using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public KeyCode up, down, left, right;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
            rb.AddForce(transform.up * 5);
        else if (Input.GetKey(down))
            rb.AddForce(transform.up * -5);
        if (Input.GetKey(left))
            rb.AddTorque(transform.forward * 2);
        else if (Input.GetKey(right))
            rb.AddTorque(transform.forward * -2);

        if (transform.position.x > 12)
            transform.position -= new Vector3(23, 0, 0);
        else if (transform.position.x < -12)
            transform.position += new Vector3(23, 0, 0);
        else if (transform.position.y > 7)
            transform.position -= new Vector3(0, 13, 0);
        else if (transform.position.y < -7)
            transform.position += new Vector3(0, 13, 0);
    }
}
