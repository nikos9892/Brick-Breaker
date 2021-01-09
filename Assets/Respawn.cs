using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    
    public GameObject ball;
    public Transform bat;
    private Vector2 startPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        RespawnEverything();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnEverything()  {
        RespawnBall();
        RespawnBat();
    }

    void RespawnBat() {
        bat.position = startPosition;
    }

    void RespawnBall() {
        ball.transform.position = startPosition + new Vector2(0, 0.6f);
        ball.GetComponent<Ball>().Stop();
    }

}
