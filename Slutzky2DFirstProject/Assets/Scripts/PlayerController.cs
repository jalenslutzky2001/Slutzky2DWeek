using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public new Rigidbody2D rigidbody2D;

    public float runSpeed = 5;
    public float jumpForce = 1;
    public bool isGrounded;



    // Start is called before the first frame update
    void Start()
    {
       rigidbody2D = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
      
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(horizontalInput * runSpeed * Time.deltaTime, 0);

        rigidbody2D.AddForce(direction);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            

        }

    }   

        
}
