using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionBehaviour : MonoBehaviour
{
    public event Action Enter;

    [SerializeField]
    LayerMask collisionLayer;

    private void OnTriggerEnter(Collider other) 
    {
        if(ContainsLayer(other.gameObject.layer))
        {
            OnEnter();
        }
    }

    bool ContainsLayer(int layer) => collisionLayer == (collisionLayer | (1 << layer));

    void OnEnter()
    {
        Enter?.Invoke();
    }
}
