using UnityEngine;

public interface IScore
{
    void AddPoints(int value);

    int GetTotalPoints();
}
