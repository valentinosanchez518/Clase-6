﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class charachterAgent : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = target.position;
    }
}
