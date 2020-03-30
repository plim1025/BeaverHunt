using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject plankPrefab;
    public GameObject duckPrefab;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPlanks();
        
    }

    private void spawnPlanks() {
        for(int i = -3; i <= 3; i++) {
            for(int j = -3; j <= 3; j++) {
                int num = Random.Range(0, 8);
                if(num == 1) {
                    GameObject plank = Instantiate(plankPrefab) as GameObject;
                    plank.transform.position = new Vector3(i*10, j*10, 0);
                }
            }
        }
    }

    private void spawnDucks() {
        counter++;
        if(counter%10000==0){
            int x = Random.Range(-35, 35);
            int y = Random.Range(-35, 35);
            GameObject Duck = Instantiate(duckPrefab) as GameObject;
            Duck.transform.position = new Vector3(x, y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnDucks();
    }
}
