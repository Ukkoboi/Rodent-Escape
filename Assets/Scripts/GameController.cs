using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Spawner spawner;
    public int enemyStartingAmount;
    public AudioSource audioSource;
    private GameObject player;
    private GameObject goal;
    public static GameController instance;
    public UIController ui;
    static float score;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

        for (int i = 0; i < enemyStartingAmount; i++)
        {
            spawner.SpawnEnemy();
        }
        player = spawner.SpawnPlayer();
        print("score " + score);
        ui.SetScore(score);
    }

    void Update()
    {
        if (player == null)
        {
            ui.ShowEndScreen(score);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level 1");
        score = 0;
    }

    public void OnTriggerEnter(Collider other)
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (other.gameObject.CompareTag("Player"))
        {

            score += 50;

            if (currentSceneIndex == 3)
            {
                SceneManager.LoadScene("End Screen");
            }
            else
            {
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }
}
