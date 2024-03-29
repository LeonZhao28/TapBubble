﻿using UnityEngine;
using System.Collections;

public class TweenSZ : TweenVec1S
{
    public static TweenSZ Add(GameObject g, float duration, float to)
    {
        return Add<TweenSZ>(g, duration, to);
    }
    
    override public float value
    {
        get
        {
            return vector.z;
        }
        set
        {
            Vector3 v = vector;
            v.z = value;
            vector = v;
        }
    }
}
