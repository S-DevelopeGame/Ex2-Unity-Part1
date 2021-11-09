using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    [SerializeField] string[] triggeringTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag[0] && enabled)
        {
            if (transform.position.x > 0)
                transform.position = new Vector3(transform.position.x * -1 + 1, transform.position.y, transform.position.z);
            else
                transform.position = new Vector3(transform.position.x * -1 - 1, transform.position.y, transform.position.z);
        }
        if (other.tag == triggeringTag[1] && enabled)
        {
            if(transform.position.y > 0)
                transform.position = new Vector3(transform.position.x, transform.position.y*-1+1, transform.position.z);
            else
                transform.position = new Vector3(transform.position.x, transform.position.y * -1 - 1, transform.position.z);
        }
    }
}
