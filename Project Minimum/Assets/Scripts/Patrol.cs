using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


    public class Patrol : MonoBehaviour
    {

        public Transform FrontDoor;
        public Transform Corridor;
        public Transform IntoOffice;
        public float wait;
        NavMeshAgent agent;


        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
                 
            StartCorridor();
        }


        void StartCorridor()
        {
            // Set the agent to go to the corridor
            agent.SetDestination(Corridor.position);

            Invoke("OpenDoor", wait);
        }

        void OpenDoor()
        {
            // Set the agent to go to the front door
            agent.SetDestination(FrontDoor.position);

            Invoke("Office", wait);

        }

        void Office()
        {
            // Set the agent to go to the front door
            agent.SetDestination(IntoOffice.position);
        }

}
