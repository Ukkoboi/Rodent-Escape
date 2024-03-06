using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Spawner spawner;

    public int enemyStartingAmount;

    public AudioSource audioSource;

    private GameObject player;
    private GameObject goal;
    public static GameController instance;
    public UIController ui;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyStartingAmount; i++)
        {
            spawner.SpawnEnemy();
        }

        goal = spawner.SpawnGoal();
        player = spawner.SpawnPlayer();

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            ui.ShowEndScreen();
        }
    }
}
