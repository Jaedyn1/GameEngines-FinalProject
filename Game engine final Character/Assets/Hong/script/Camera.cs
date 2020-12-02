using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Camera : MonoBehaviour
{
    public Transform playertransform;

    private Vector3 _cameraOffset;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPlayer = false;


    void Start()
    {
        _cameraOffset = transform.position - playertransform.position;
    }

    void LateUpdate()
    {
        Vector3 newPos = playertransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer)
            transform.LookAt(playertransform);
    }
}
