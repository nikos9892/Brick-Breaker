﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour {
    public Respawn respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        Ball ball = other.GetComponent<Ball>();
        bool isBall = ball != null;
        if (isBall) {
            respawnPoint.RespawnEverything();
        }
    }
}
