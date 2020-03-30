using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaver1 : MonoBehaviour
{
    public float speed = 11.0f;
    public int wood = 1;
    private Vector2 direction = Vector3.zero;
    // private TextMesh scoreboard;

    void Start()
    {

    }
    private void Update()
    {
        PlayerInput();
        Move();
        ChangeOrientation();
        DetectWin();
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
        if(!(transform.position.x > 38 && direction.x == 1) && !(transform.position.x < -38 && direction.x == -1) && !(transform.position.y > 40 && direction.y == 1) && !(transform.position.y < -40 && direction.y == -1)) {
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

    private void OnTriggerEnter2D(Collider2D other){
        // scoreboard = (TextMesh)GameObject.Find ("Scoreboard").GetComponent<TextMesh>();
            
        if(other.gameObject.name.Contains("Plank")){
            wood+=1;
            Scoreboard.addMultiplier1();
            Destroy(other.gameObject);
        }
        if(other.gameObject.name == "Big Duck"){
            Destroy(other.gameObject);
            Application.Quit();
        } else if(other.gameObject.name.Contains("Duck")){
            Destroy(other.gameObject);
            Scoreboard.newchange(100*wood);
        }
    }
    
    void DetectWin() {
        int count = 0;
        GameObject duck = GameObject.Find("Duck");
        GameObject duck1 = GameObject.Find("Duck (1)");
        GameObject duck2 = GameObject.Find("Duck (2)");
        GameObject duck3 = GameObject.Find("Duck (3)");
        GameObject duckClone = GameObject.Find("Duck(Clone)");
        if(duck == null && duck1 == null && duck2 == null && duck3 == null && duckClone == null) {
            Application.Quit();
        }
    }

}
