using Destructible2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour {
    private Rigidbody2D body;
    public D2dGun gun;
    public float movementSpeed;
    public int jumpHeight;
    private float horizontal;
    // Use this for initialization
    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        movementHandler();
        
    }
    public void movementHandler() {
        body.velocity = new Vector2(horizontal * movementSpeed, body.velocity.y);
        if (Input.GetKeyDown("space") /*&& body.velocity.y == 0*/) {
            body.AddForce(new Vector2(1, jumpHeight));
        }
        
        if (Input.GetMouseButtonDown(0) == true) {
            
            //if (cooldown <= 0.0f) {
            //    cooldown = ShootDelay;
            
                //Shootaah
                if (gun != null && gun.CanShoot == true) {
                    gun.Shoot();
                }
            }
        }
    
}
