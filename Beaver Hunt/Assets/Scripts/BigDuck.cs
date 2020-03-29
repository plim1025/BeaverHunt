using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDuck : MonoBehaviour
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
            var gObj = GameObject.Find("Beaver");
            if (gObj){
                int rand = Random.Range(0, 2);
                if(rand == 0) {
                    if(gObj.transform.position.x > transform.position.x) {
                        direction = Vector2.right;
                    } else {
                        direction = Vector2.left;
                    }
                } else if (rand == 1) {
                    if(gObj.transform.position.y > transform.position.y) {
                        direction = Vector2.up;
                    } else {
                        direction = Vector2.down;
                    }
                }
                
            }
        }
        
        if(!(transform.position.x > 38 && direction.x == 1) && !(transform.position.x < -38 && direction.x == -1) && !(transform.position.y > 40 && direction.y == 1) && !(transform.position.y < -40 && direction.y == -1)) {
            transform.position += ((Vector3)(direction * speed)) * Time.deltaTime;
        }
    }

    void ChangeOrientation(){
        if(direction== Vector2.left){
            transform.localScale = new Vector3(2,2,10);
        }
        if(direction== Vector2.right){
            transform.localScale = new Vector3(-2,2,10);
        }
    }
}
