using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSideMovement : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float side_movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.A) && gameObject.transform.position.x != -speed)
        {
            gameObject.transform.Translate(Vector3.left * speed);
        }
        else if (Input.GetKeyDown(KeyCode.D) && gameObject.transform.position.x != speed)
        {
            gameObject.transform.Translate(Vector3.right * speed);
        }
    }
}
