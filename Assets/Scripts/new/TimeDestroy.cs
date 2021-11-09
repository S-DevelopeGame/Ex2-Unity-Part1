using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    [Tooltip("Choose time that the object will be destroy")]
    [SerializeField] private int timeDestroyObject;
    void Start()
    {
        this.StartCoroutine(destroyObject());
    }
    private IEnumerator destroyObject()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(timeDestroyObject);
            Destroy(this.gameObject);
        }
    }
}
