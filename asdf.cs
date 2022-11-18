using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdf : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos;
    public float startDelay = 2;
    public float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {

        // PlayerControllerscript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        spawnPos = gameObject.transform.position;
    }

    void SpawnObstacle()
    {


        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);


    }
}