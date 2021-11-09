using System.Collections;
using UnityEngine;

public class ShieldThePlayer : MonoBehaviour {
    [Tooltip("The number of seconds that the shield remains active")] [SerializeField] float duration;
    [Tooltip("the sprite renderer of the shield")] [SerializeField] private SpriteRenderer sheild;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Power") { // collision with Power tag
            Debug.Log("Shield triggered by player");
            var destroyComponent = GetComponent<DestroyOnTrigger2D>(); // get the HealBar component
            Debug.Log(destroyComponent);
            if (destroyComponent) {
                destroyComponent.StartCoroutine(ShieldTemporarily(destroyComponent));
                // NOTE: If you just call "StartCoroutine", then it will not work, 
                //       since the present object is destroyed!
                Destroy(other.gameObject);  // Destroy the shield itself - prevent double-use
            }
        } else {
            Debug.Log("Shield triggered by "+other.name);
        }
    }
    private IEnumerator ShieldTemporarily(DestroyOnTrigger2D destroyComponent) {
        destroyComponent.enabled = false;
        sheild.enabled = true;
        float aColor = 1f; // 1f for full color
        for (float i = duration; i > 0; i--) {
            Debug.Log("Shield: " + i + " seconds remaining!");
            sheild.color = new Color(1f, 1f, 1f, aColor);
            aColor -= 1f / duration; // Weakening color by the duration time
            yield return new WaitForSeconds(1);
        }
        Debug.Log("Shield gone!");
        sheild.enabled = false;
        destroyComponent.enabled = true;
    }
}
