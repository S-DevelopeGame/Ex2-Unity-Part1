using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] string sceneName;

    // Start is called before the first frame update
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
    }
}
