using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Callback : MonoBehaviour {
    public GameObject ExplotionPrefab;
    public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;

    void Start() {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    private void OnParticleCollision(GameObject other) {
        //Instantiate(ExplotionPrefab,other.transform.position , Quaternion.identity);

        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        int i = 0;

        while (i < numCollisionEvents) {
            
                Instantiate(ExplotionPrefab, collisionEvents[i].intersection, Quaternion.identity);
            
            i++;
        }



    }

}


