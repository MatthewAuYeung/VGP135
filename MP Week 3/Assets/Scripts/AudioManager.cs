﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager
{
    Vector3 v1 = Vector3.up;
    Vector3 v2 = Vector3.right;
    public void Initalize()
    {
        for (int i = 0; i< 100000000; ++i)
        {
            AddVector(v1, v2);
        }
    }

    private Vector3 AddVector(Vector3 v1, Vector3 v2)
    {
        return v1 + v2;
    }
}
