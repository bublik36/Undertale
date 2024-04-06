using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWeapons : MonoBehaviour
 {
    public float speed;
    public Rigidbody2D weapons;
    public Vector2 mve;
    public Transform player;

    private void Awake() {
        weapons = GetComponent<Rigidbody2D>();  
        player =  GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();        

    }private void FixedUpdate() {
        
        weapons.velocity = transform.TransformDirection(mve * speed * Time.deltaTime);
    }private void Start() {

    }private void Update() {
        mve = player.position;
    }



}
   

