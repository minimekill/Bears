using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusJumper : MonoBehaviour {

    public GameObject player;
    private bool isDead = true;
    public GameObject bus;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && isDead) {
            GameObject player1 = Instantiate(player);
            player1.transform.position = new Vector2(bus.transform.position.x, bus.transform.position.y);
            isDead = false;
        }
    }

}
