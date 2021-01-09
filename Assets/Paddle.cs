using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float boundXLeft = -9.44f;
    float boundXRight = 9.46f;

    public float speed = 5f;

    private float input;
    private Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    
        transform.position = new Vector3(0,-4.14f,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < boundXLeft)
        {
            transform.position = new Vector3(boundXLeft, -4.14f, 0);
        }

        if (transform.position.x > boundXRight)
        {
            transform.position = new Vector3(boundXRight, -4.14f, 0);
        }
        input = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * input * speed;
    }
}
