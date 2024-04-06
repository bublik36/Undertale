using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWave : MonoBehaviour
{
    public float speed;
    public Rigidbody2D wave;
    public HPenemy hpEnn; 
    public bool Click;
    public Switch switcher;
    
    private void Update() {
        transform.Translate(new Vector2(0.1f * speed,wave.velocity.y) * Time.deltaTime);
        if(transform.localPosition.x >= -0.6){
         transform.localPosition = new Vector2(-6.31f,-3.59f);   
        }
    }private void Awake() {
        wave = GetComponent<Rigidbody2D>();
        hpEnn = GameObject.FindGameObjectWithTag("enemy").GetComponent<HPenemy>();
        Click = true;
        switcher = GameObject.Find("Switcher").GetComponent<Switch>();
    }private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.CompareTag("threeDamage") && Click == true ){
            if(Input.GetMouseButtonDown(0)){
            Click = false;    
            hpEnn.HpEnemmy -= 3;
                         for(int o = 0;o < switcher.switchWave.Length;o++){
                 switcher.switchWave[o].gameObject.SetActive(false);
             }
             for(int i = 0;i <switcher.switchPlayer.Length;i++){
                 switcher.switchPlayer[i].gameObject.SetActive(true);
             }

            }
        } if(other.gameObject.CompareTag("fiveDamage") && Click == true ){
            if(Input.GetMouseButtonDown(0)){
            Click = false;    
            hpEnn.HpEnemmy -= 5;
                         for(int o = 0;o < switcher.switchWave.Length;o++){
                 switcher.switchWave[o].gameObject.SetActive(false);
             }
             for(int i = 0;i <switcher.switchPlayer.Length;i++){
                 switcher.switchPlayer[i].gameObject.SetActive(true);
             }

            }
    } if(other.gameObject.CompareTag("tenDamage") && Click == true ){
            if(Input.GetMouseButtonDown(0)){
            Click = false;    
            hpEnn.HpEnemmy -= 10;
                for(int o = 0;o < switcher.switchWave.Length;o++){
                switcher.switchWave[o].gameObject.SetActive(false);
             }
             for(int i = 0;i <switcher.switchPlayer.Length;i++){
                 switcher.switchPlayer[i].gameObject.SetActive(true);
             }

            }
    } if(other.gameObject.CompareTag("fivthnDamage") && Click == true ){
            if(Input.GetMouseButtonDown(0)){
            Click = false;    
            hpEnn.HpEnemmy -= 15;
             for(int o = 0;o < switcher.switchWave.Length;o++){
                 switcher.switchWave[o].gameObject.SetActive(false);
             }
             for(int i = 0;i <switcher.switchPlayer.Length;i++){
                 switcher.switchPlayer[i].gameObject.SetActive(true);
             }
            }
    }
    
}
}
