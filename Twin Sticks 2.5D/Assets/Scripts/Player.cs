using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour {

    bool isGrounded = false;
    Rigidbody myRigidbody;
	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        OnPressButtons();
	}
    void OnPressButtons()
    {
        Move();
    }
    void Move()
    {
        float horizontal = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        Vector3 moveHorizontal = new Vector3(horizontal, 0, 0);
        transform.position += moveHorizontal * 5f * Time.deltaTime;

        //Jump
        if (CrossPlatformInputManager.GetButtonDown("Jump") && isGrounded)
        {
            myRigidbody.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            isGrounded = !isGrounded;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        isGrounded = !isGrounded;
    }
}
