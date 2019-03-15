﻿using System.Collections;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField]
    public float debugDrawRadius = 1.0f;

    public virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, debugDrawRadius);
    }
}
