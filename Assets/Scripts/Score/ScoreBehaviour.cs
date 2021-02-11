using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour, IScore
{
    int currentScore;

    private void Awake() 
    {
        currentScore = 0;   
    }

    public void AddPoints(int value)
    {
        currentScore += value;
    }

    public int GetTotalPoints()
    {
        return currentScore;
    }

    
}
