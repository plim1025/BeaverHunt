using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaver : MonoBehaviour
{
    public float speed = 11.0f;
    private Vector2 direction = Vector3.zero;
    public bool power = 0;
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
            transform.localScale = new Vector3(2,2,2);
        }
        if(direction== Vector2.right){
            transform.localScale = new Vector3(-2,2,2);
        }
    }
/*
    GameObject getposition(Vector2 pos){
        int tilex = Mathf.RoundToInt(pos.x);
        int tiley = Mathf.RoundToInt(pos.y);
        //GameObject tile =
        if(tile != null){
            return tile;
        }
        else
            return null;
    }
*/
    private void OnTriggerEnter2D(Collider2D other){
        //Destory(other.gameObject);
        if(other.GetType=="Plank"){
            other.gameObject.SetActive(false);
            power = true;
        }
        if(other.GetType=="Duck(4)"){
            other.gameObject.SetActive(false);
            Application.Quit();
        }
        if(other.GetType=="Duck(3)"){
            other.gameObject.SetActive(false);
            score++;
        }
    }
    
}
