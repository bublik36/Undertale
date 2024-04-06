using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float Dmage;
    public hp playerHP;
    private void Awake() {
        playerHP = GameObject.FindGameObjectWithTag("Player").GetComponent<hp>();
    }private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.CompareTag("Player") && playerHP.GetDamaged == true){
            playerHP.HealthPoint -= Dmage;
            Destroy(gameObject);
        }if(other.gameObject.CompareTag("arena")){
            Destroy(gameObject);
        }else if(other.gameObject.CompareTag("Player") && playerHP.GetDamaged == false){
            Destroy(gameObject);
        }
    }
}
