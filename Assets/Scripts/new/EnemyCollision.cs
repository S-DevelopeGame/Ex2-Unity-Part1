using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
   
    [SerializeField] string[] triggeringTag;
    [SerializeField] private int lifes;
    [SerializeField] private int damage;
    [SerializeField] private NumberField scoreField;


    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag[0] && enabled) //enemy collision power of player
        {
            Destroy(other.gameObject);
            lifes -= damage;
            if(lifes <= 0)
            {
                Destroy(this.gameObject);
            }

        }


    }




}