using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform centerOfRotationTransform;
    public float rotationSpeed;
    public Vector3 axisRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.RotateAround(centerOfRotationTransform.position, axisRotation, rotationSpeed * Time.deltaTime);
    }

    private void Reset()
    {
        centerOfRotationTransform = gameObject.transform;
        rotationSpeed = 180.0f;
        axisRotation = Vector3.up;
    }
}
