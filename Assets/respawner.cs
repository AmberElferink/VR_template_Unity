using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawner : MonoBehaviour
{

    Vector3 start_pos;
    // Start is called before the first frame update
    void Start()
    {
        start_pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, start_pos) > 1.5)
        {
            this.transform.position = start_pos;
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
