using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (other.gameObject.CompareTag("Player"))
        {

            if (currentSceneIndex == 3)
            {
                SceneManager.LoadScene("Level 4");
            }
            else
            {
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }
}
