using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    Vector3 offset;
    GameObject ball;
	// Use this for initialization
	void Start () {
        ball = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = ball.transform.position + offset;
	}
}
