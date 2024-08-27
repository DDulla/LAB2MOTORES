using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public Rigidbody2D rigidbody2;
    public float Horizontal;
    public float velocityy;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void FixedUpdate()
    {
        movement();
    }
    void movement()
    {
        float inputMovement = Input.GetAxis("Horizontal");
        rigidbody2.velocity = new Vector2(inputMovement * velocityy, rigidbody2.velocity.y);
    }
}
