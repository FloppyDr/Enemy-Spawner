﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _wayPoint;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _wayPoint.position, _speed * Time.deltaTime);
    }
}
