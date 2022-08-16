using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Shooter
{
    public class NavigationAgent : MonoBehaviour
    {

        private NavMeshAgent Agent;
        [SerializeField] private GameObject target;
        // Start is called before the first frame update
        void Start()
        {
            Agent = GetComponent<NavMeshAgent>();
            Agent.destination = target.transform.position;
        }



        // Update is called once per frame
        void Update()
        {

        }


    }
}