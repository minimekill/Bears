using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMove : MonoBehaviour {

    public int speed;
    public GameObject bus;
    private Rigidbody2D body;

    void Start () {
        body = bus.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        body.transform.Translate(speed * Time.deltaTime, 0, 0);
	}
}
