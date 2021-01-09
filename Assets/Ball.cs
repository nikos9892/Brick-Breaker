using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour {

  public float speed = 5f; 
  public bool inMovement;
  private Vector2 startPosition;
  public Text pointsText;
  private uint points = 0;

  // Start is called before the first frame update
  void Start () {
    startPosition = transform.position;
     pointsText.text = "0";
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("Jump") && !inMovement) {
      GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
      inMovement = true;
    }


    Vector2 currentVelocity = GetComponent<Rigidbody2D>().velocity;
    if (inMovement) {
      Debug.Log(currentVelocity.ToString());
      Vector2 newVelocity = NormalizeVector(currentVelocity);
      GetComponent<Rigidbody2D>().velocity = newVelocity;
    }
  }

  Vector2 NormalizeVector(Vector2 v) {
    if (v.x < 1f && v.x > -1f) {
      v.x = 1f;
    }
    if (v.y < 1f && v.y > -1f) {
      v.y = 1f;
    }
    return v;
  }

  public void Stop() {
    inMovement = false;
  }

  public void Respawn(bool loadScene = false) {
    transform.position = startPosition;
    inMovement = false;
  }
  
  void OnCollisionEnter2D(Collision2D other) {
    Brick brick = other.gameObject.GetComponent<Brick>();
    bool isBrick = brick != null;
    if (isBrick) {
      UpdatePoints();
    }
  }

  private void UpdatePoints() {
    points++;
    pointsText.text = points.ToString();
  }
} 
