using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaver : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector2 direction = Vector3.zero;
    void Start()
    {

    }
    private void Update()
    {
        PlayerInput();
        Move();
    }


    void PlayerInput(){
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            direction = Vector2.left;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            direction = Vector2.right;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            direction = Vector2.down;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            direction = Vector2.up;
        }
    }

    void Move(){
        if(!(transform.position.x > 35 && direction.x == 1) && !(transform.position.x < -35 && direction.x == -1) && !(transform.position.y > 34 && direction.y == 1) && !(transform.position.y < -34 && direction.y == -1)) {
            transform.position += ((Vector3)(direction * speed)) * Time.deltaTime;
        }
    }
    
}
