using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag1;
    [SerializeField] string triggeringTag2;
    [SerializeField] private int lifes = 3;
    [SerializeField] private HealthPlayer healthPlayer;
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private string gameOverScene;


    private void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.tag == triggeringTag1 || other.tag == triggeringTag2 && enabled)
        {
            Destroy(other.gameObject);
            healthPlayer.setDamage(healthPlayer.getDamage());
            if (healthPlayer.getCurrentHealth() < 1)
            {
                audioManager.die();
                Destroy(this.gameObject);
                SceneManager.LoadScene(gameOverScene);
            }
        }



    }
}
