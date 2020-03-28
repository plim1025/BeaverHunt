using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
/*     public float speed = 3.9f;

    public Node startarea;
    public int scattermode1 = 7;
    public int chasemode1 = 7;
    public int scattermode2 = 7;
    public int chasemode2 = 20;
    public int scattermode3 = 7;
    public int chasemode3 = 20;
    public int scattermode3 = 5;
    public int chasemode3 = 20;
    public int scattermode4 = 6;
    public int chasemode4 = 20;



    private int modechange = 1;
    private float modetimer = 0;

    public enum Mode{
        Chase, Scatter, Frightened
    }

    Mode current = Mode.Scatter;
    Mode previousMode; */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // We add +1 to the x axis every frame.
        // Time.deltaTime is the time it took to complete the last frame
        // The result of this is that the object moves one unit on the x axis every second
        transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
    }
}
