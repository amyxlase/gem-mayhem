using UnityEngine;
using System.Collections;

public class Gem : MonoBehaviour {

    public Vector3 rotationAngle;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per rendered frame
	void Update () {
        
	}

	// FixedUpdate is called once per physics frame
	// Let's rotate the transform of each gem here using the rotation 
	// angle, rotation speed, and the delta time between updates !
	void FixedUpdate () {
		transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
	}
}
