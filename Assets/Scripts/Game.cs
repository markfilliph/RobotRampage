using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    private static Game singleton;
    [SerializeField]
    RobotSpawn[] spawns;
    public int enemiesLeft;

    public GameUI gameUI;
    public GameObject player;
    public int score;
    public int waveCountdown;
    public bool isGameOver;
    // 1
    void Start()
    {
        singleton = this;
        SpawnRobots();
    }
    // 2
    private void SpawnRobots()
    {
        foreach (RobotSpawn spawn in spawns)
        {
            spawn.SpawnRobot();
            enemiesLeft++;
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
