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
            if (currentSceneIndex == 2)
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
