using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanks : MonoBehaviour
{
    public GameObject plankPrefab;

    // Start is called before the first frame update
    void Start()
    {
        spawnPlanks();
    }

    private void spawnPlanks() {
        for(int i = -3; i <= 3; i++) {
            for(int j = -3; j <= 3; j++) {
                int num = Random.Range(0, 2);
                print(num);
                if(num == 1) {
                    GameObject plank = Instantiate(plankPrefab) as GameObject;
                    plank.transform.position = new Vector3(i*10, j*10, 0); 
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
