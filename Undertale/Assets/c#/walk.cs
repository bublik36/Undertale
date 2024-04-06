using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed;
    private void Awake() {
        player = GetComponent<Rigidbody2D>();
    }   private void FixedUpdate() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        player.velocity = transform.TransformDirection(new Vector2(x,y) * speed * Time.deltaTime);
    }
}
