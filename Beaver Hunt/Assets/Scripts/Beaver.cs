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
        print(transform.localScale);
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
        if(!(transform.position.x > 35 && direction.x == 1) && !(transform.position.x < -35 && direction.x == -1) && !(transform.position.y > 35 && direction.y == 1) && !(transform.position.y < -35 && direction.y == -1)) {
            transform.position += ((Vector3)(direction * speed)) * Time.deltaTime;
        }
    }

    void ChangeOrientation(){
        if(direction== Vector2.left){
<<<<<<< HEAD
            transform.localScale = new Vector3(3,3,2);
        }
        if(direction== Vector2.right){
            transform.localScale = new Vector3(-3,3,2);
=======
            transform.localScale = new Vector3(2,2,2);
        }
        if(direction== Vector2.right){
            transform.localScale = new Vector3(-2,2,2);
>>>>>>> fc7a97d2ba93cd2851255aac61c6e7fd562eee31
        }
    }
    
}
