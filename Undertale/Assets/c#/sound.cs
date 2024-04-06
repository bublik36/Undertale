using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public GameObject soundSource;
    private void Awake() {
        Instantiate(soundSource,transform.position,Quaternion.identity);

    }private void Update() {

    }
}
