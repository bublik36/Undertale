using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public float HealthPoint;
    public float maxHealthPoint;
    public float minHealthPoint;
    public Slider sliderr;
    public Text textt;
    public Animator anim;
    public bool GetDamaged;
    public Collider2D playerDie;
    private void Update() {
        if(HealthPoint > maxHealthPoint){
            HealthPoint = maxHealthPoint;
        }if(HealthPoint <= minHealthPoint){
            HealthPoint = 0;
        }if(HealthPoint <= 0 ){
            Destroy(playerDie);
        }SetHealth();
        textt.text =  HealthPoint.ToString() + "/20"; 
        anim.SetFloat("HealthPoint", HealthPoint);
    }public void SetMaxHealth(){
        sliderr.maxValue = maxHealthPoint;
        sliderr.value = maxHealthPoint;
    }public void SetHealth(){
        sliderr.value = HealthPoint;
    }public void TurnOff(){
        Destroy(gameObject);
    }private void Awake() {
        maxHealthPoint = 20;
        SetMaxHealth();
        textt = GameObject.Find("HealthNum").GetComponent<Text>();
        anim = GetComponent<Animator>();
        GetDamaged = true;
        playerDie = GetComponent<Collider2D>();
    }

        IEnumerator GetDamag(){
        GetDamaged = false;
        anim.Play("GetDamage");
        yield return new WaitForSeconds(1.5f);
        GetDamaged = true;
        }
    private void OnCollisionEnter2D(Collision2D other) {
             if(other.gameObject.CompareTag("weapons")){
        StartCoroutine(GetDamag());
     } 
    }   
     }
    

