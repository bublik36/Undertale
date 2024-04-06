using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject[] switchPlayer;
    public GameObject[] switchWave;
    public moveWave movingVave;
    public GameObject[] weaponsTag;
    private void Start() {
           foreach(GameObject s in switchPlayer){
                s.gameObject.SetActive(false);
            }foreach(GameObject a in switchWave){
                a.gameObject.SetActive(true);
            }
    }       
}    