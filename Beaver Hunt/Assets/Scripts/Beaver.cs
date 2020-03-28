using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaver : MonoBehaviour
{
    public float speed = 4.0f;
    private Vector2 direction = Vector3.zero;
    void Start()
    {

    }
    private void Update()
    {
        PlayerInput();
        Move();
        ChangeOrientation();
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
        transform.position += ((Vector3)(direction * speed)) * Time.deltaTime;

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
