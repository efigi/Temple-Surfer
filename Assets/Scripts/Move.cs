using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public float maxSpeed;
    public Rigidbody body;

    private Vector3 vel;
    private void Reset()
    {
        direction = Vector3.forward;
        speed = 3;
        maxSpeed = 300;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (!body)
        {
            body = GetComponent<Rigidbody>();
            vel = direction * speed;
        }
        //body.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    //void FixedUpdate()
    void Update()
    {
        //body.AddForce(direction * speed);
        //body.velocity = Vector3.ClampMagnitude(body.velocity, maxSpeed);
        gameObject.transform.Translate(direction * speed * Time.deltaTime);
    }
}
