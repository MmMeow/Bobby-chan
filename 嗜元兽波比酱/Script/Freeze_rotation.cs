﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze_rotation : MonoBehaviour
{

    public float lockPos = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
    }
}
