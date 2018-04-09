using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour {
    
    private Vector3 dir;
    private ParticleSystem flameThrower;
    public GameObject flameBody;
    //public AudioClip flames;
    public GameObject flameCollider;
    private ParticleSystem system;
    private float temp = 0;
    private Vector3 mouse_pos;
    private Vector3 object_pos;
    private float angle = 0;
    void Start () {
        flameThrower = flameBody.GetComponent<ParticleSystem>();
        reset();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetMouseButton(0)) {
            flameThrower.emissionRate = 100.0f;


            //Needs some cleaning up, "someone" should do it!

            //the vector between mouse and whatever shoots.
            
            //flameBody.transform.Rotate(dir.x,90,0,Space.World);
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dir = worldMousePosition - new Vector3(flameBody.transform.position.x,flameBody.transform.position.y,0);
            //dir.Normalize();
            dir = new Vector3(dir.x, dir.y, 0);
            //var mouse = Input.mousePosition;
            //mouse.z = -(flameBody.transform.position.x - Camera.main.transform.position.x);


            //Vector3 worldPos = Camera.main.ScreenToWorldPoint(mouse);
            //flameBody.transform.LookAt(new Vector3(mouse.x,90,0));
            if(dir.y < 0) {
                angle = Vector3.Angle(dir, new Vector3(1, 0, 0)) * -1;
            } else {
                angle = Vector3.Angle(dir, new Vector3(1, 0, 0));
            }
            flameBody.transform.rotation = Quaternion.Euler(-angle, 90, 0);
            
            Debug.Log(angle);
            
            Debug.Log(dir);

        } else {
            reset();
        }
    }


    public void reset() {
        flameThrower.emissionRate = 0.0f;
    }

}
