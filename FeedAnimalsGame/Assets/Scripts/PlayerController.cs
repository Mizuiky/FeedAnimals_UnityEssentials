using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float xBoundarie;

    private float horizontalInput;


    void Start()
    {
    
    }
    private void Update()
    {
        this.horizontalInput = Input.GetAxis("Horizontal");

        if (this.transform.position.x < -xBoundarie)
        {
            this.transform.position = new Vector3(-xBoundarie, this.transform.position.y, this.transform.position.z);
        }
        else if (this.transform.position.x > xBoundarie)
        {
            this.transform.position = new Vector3(xBoundarie, this.transform.position.y, this.transform.position.z);
        }

        this.transform.Translate(Vector3.right * horizontalInput * playerSpeed * Time.deltaTime);
    }
    
    void FixedUpdate()
    {
        
        
        //this.body.AddForce(Vector3.right * horizontalInput * playerSpeed * Time.fixedDeltaTime);

        //this.transform.position = new Vector3(horizontalInput * playerSpeed * Time.fixedDeltaTime, 0, 0);
    }
}
