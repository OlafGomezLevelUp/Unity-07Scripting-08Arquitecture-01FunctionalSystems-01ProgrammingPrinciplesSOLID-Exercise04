using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyValue : MonoBehaviour
{
    [SerializeField]
    int enemyScoreValue = 10;
   
    public int GetEnemyValue()
    {
        return enemyScoreValue;
    }
}
