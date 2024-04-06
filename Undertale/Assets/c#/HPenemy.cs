using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HPenemy : MonoBehaviour
{
    public float HpEnemmy;
    public float maxHpEnemy;
    public Slider slid;
    public Text TXT;
    public float minHp;
    private void Update() {
                if(HpEnemmy > maxHpEnemy){
            HpEnemmy = maxHpEnemy;
        }if(HpEnemmy <= minHp){
            HpEnemmy = 0;
        }TXT.text = HpEnemmy.ToString() + "/100"; 
        SetHealth();
    }public void SetHealth(){
        slid.value = HpEnemmy;
    }public void SetMaxHealth(){
        slid.maxValue = maxHpEnemy;
        slid.value = maxHpEnemy;
    }private void Awake() {
        TXT = GameObject.Find("HealthNum2").GetComponent<Text>();
        SetMaxHealth();
    }

}
