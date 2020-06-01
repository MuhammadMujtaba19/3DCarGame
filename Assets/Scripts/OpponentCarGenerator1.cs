﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentCarGenerator1 : MonoBehaviour
{
    public GameObject oppoCar;

    public Transform objectToFollow;
    public Vector3 offset = new Vector3(0f, 0f, 20f);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateRandomObstacle", 1f, 1.5f);
    }

    // Update is called once per frame
    private void GenerateRandomObstacle()
    {
        float number = Random.Range(0f, 2.5f);
        float zaxis = Random.Range(0f, 66f);

        Instantiate(oppoCar, new Vector3(number, 0f, transform.position.z), Quaternion.Euler(0f, 0f, 0f));

    }
    void FixedUpdate()
    {

        //      Vector3 _targetPos = objectToFollow.position + 
        //					 objectToFollow.forward * offset.z + 
        //					 //objectToFollow.right * offset.x + 
        //					 objectToFollow.up * offset.y;
        //transform.position = Vector3.Lerp(transform.position, _targetPos, 10f * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0f, objectToFollow.position.z + offset.z);
    }
}
