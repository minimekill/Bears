using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameLogic : MonoBehaviour {

    public List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();

    public ParticleSystem flame;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int size = flame.GetTriggerParticles(ParticleSystemTriggerEventType.Enter,enter);

        for(int i = 0; i < size; i++) {
            ParticleSystem.Particle p = enter[i];
            //if()

        }
	}
}
