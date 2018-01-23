using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawning : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform Checkpoint2;
    [SerializeField] private Transform StartingPoint;
    public GameObject Theplayer;
    public GameObject Respawnpoint1;
    public GameObject Respawnpoint2;
    public GameObject StartPoint;


    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
    }

    void Update()
    {
       

        if (GameObject.Find("FirstGoalTrigger").GetComponent<Level1End>().CheckPoint1)
        {

            respawnPoint = Checkpoint2;
        }
        else
            respawnPoint = StartingPoint;
        }

    }



