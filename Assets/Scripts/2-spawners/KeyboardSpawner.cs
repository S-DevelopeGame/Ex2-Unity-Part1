using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class KeyboardSpawner: MonoBehaviour {


    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
    [SerializeField] private float timeShot;
    protected bool isActive = true;
    protected virtual GameObject spawnObject() {
        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover) {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }

    private void Update() {
        
        if (Input.GetKeyDown(keyToPress) && isActive && keyToPress == KeyCode.Space)
        {
            StartCoroutine(shoot());
        }
                        
    }

    public IEnumerator shoot()
    {
        //Instantiate your projectile
        spawnObject(); // spawn the shoot
        isActive = false; // not allow to shoot
        //wait for some time
        yield return new WaitForSeconds(timeShot); // wait some times
        isActive = true; // allow to shoot
    }


}
