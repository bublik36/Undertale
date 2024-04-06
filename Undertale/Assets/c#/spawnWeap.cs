using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnWeap : MonoBehaviour
{
      public Switch switcher;
     public float randomX;

   public Vector2 randomSpawn;
     public GameObject weapons;
     public bool CanSpawn;
     public float TimeToCanSp;
     private void Awake() {
         switcher = GameObject.Find("Switcher").GetComponent<Switch>();
         CanSpawn = true;
     }  
        void SpawnY(){
         randomX = Random.Range(-1.503f,1.721f);
         randomSpawn = new Vector2(randomX,-1.67f);
        Instantiate(weapons,randomSpawn,Quaternion.identity);
     }private void Update() {
        for(int i = 0; i < switcher.switchPlayer.Length;i++){
            if(switcher.switchPlayer[i].activeInHierarchy && CanSpawn == true){
                 InvokeRepeating("SpawnY",0,0);
                 StartCoroutine(CanSpawnn());
           }
     }      
     }IEnumerator CanSpawnn(){
        CanSpawn = false;
        yield return new WaitForSeconds(TimeToCanSp);
        CanSpawn = true;
     }
}