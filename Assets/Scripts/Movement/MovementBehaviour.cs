using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    [SerializeField]
    float speed;

    public void HorizontalMovement(float direction)
    {
        transform.position += Vector3.right * speed * direction * Time.deltaTime;
    }

    public void VerticalMovement()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
