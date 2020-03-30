using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private static int score = 0;
    private static int scoremultiplier = 1;
    private static int scoremultiplier1 = 1;
    public static void addMultiplier()
    {
        scoremultiplier++;
    }
    public static void addMultiplier1()
    {
        scoremultiplier1++;
    }
    public static int newchange(int result)
    {
        score += result;
        return score;
    }
    void Update()
    {
        // Set the text of the attached Text mesh
        GetComponent<TextMesh>().text = "Score: " + score + "     Multiplier1: " +scoremultiplier+"     Multiplier1: " +scoremultiplier1;
        if(score == -1){
            GetComponent<TextMesh>().text = "Game Over!";
        }
    }
}
