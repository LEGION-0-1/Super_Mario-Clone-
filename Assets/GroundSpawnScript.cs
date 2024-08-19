using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundSpawnScript : MonoBehaviour
{
    public GameObject Ground;
    public float spawnRate = 2; 
    //private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnGround();
    }
    void spawnGround()
    {/*
        float lowest = transform.position.x;
        float highest = transform.position.x;
        lowest = 10;
        highest = 20;
        Instantiate(Ground, new Vector2(Random.Range(lowest, highest), transform.position.y));*/
    }
}