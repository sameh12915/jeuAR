using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDep : MonoBehaviour
{
    float speed = 0f;
 void Start() 
  { speed = Random.Range(0.1f, 0.5f);
  transform.LookAt(Camera.main.transform); }
void Update()
 { 
     
     
     transform.Translate(Vector3.forward * speed * Time.deltaTime); }
}
