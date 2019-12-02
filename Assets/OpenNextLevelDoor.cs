﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNextLevelDoor : MonoBehaviour
{
    public Transform player;

    public float speed;

    public float detectionDistance;

    private Transform top, bottom;
    // Start is called before the first frame update
    void Start()
    {
        top = transform.GetChild(0);
        bottom = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.x - player.position.x)<= detectionDistance)
        {
            top.position += Vector3.up * speed * Time.deltaTime;

            bottom.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
