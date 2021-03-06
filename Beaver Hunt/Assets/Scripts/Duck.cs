﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector2 direction = Vector3.zero;
    private long counter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ChangeOrientation();
    }

    void Move() {
        counter++;
        if(counter%100 == 0) {
            int rand = Random.Range(0, 4);
            if(rand == 0) {
                direction = Vector2.left;
            } else if (rand == 1) {
                direction = Vector2.right;
            } else if (rand == 2) {
                direction = Vector2.down;
            } else {
                direction = Vector2.up;
            }
        }
        
        if(!(transform.position.x > 38 && direction.x == 1) && !(transform.position.x < -38 && direction.x == -1) && !(transform.position.y > 40 && direction.y == 1) && !(transform.position.y < -40 && direction.y == -1)) {
            transform.position += ((Vector3)(direction * speed)) * Time.deltaTime;
        }
    }

    void ChangeOrientation(){
        if(direction== Vector2.left){
            transform.localScale = new Vector3(1,1,1);
        }
        if(direction== Vector2.right){
            transform.localScale = new Vector3(-1,1,1);
        }
    }
}
