using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreadMillMove : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject,5.0f);
    }

    void Update()
    {
        transform.Translate(Vector3.back*speed*Time.deltaTime);
    }
}
