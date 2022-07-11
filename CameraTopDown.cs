using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTopDown : MonoBehaviour
{
    public float velocidade = 5.0f;
    public Transform target;
    public Vector3 offset = Vector3.up;
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, target.position + offset, velocidade * Time.deltaTime);

    }
}
