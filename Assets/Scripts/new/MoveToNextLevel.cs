using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    [SerializeField] private string triggeringTag;
    [SerializeField] private string sceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == triggeringTag)
        {
            SceneManager.LoadScene(sceneName);
        }

    }
}
