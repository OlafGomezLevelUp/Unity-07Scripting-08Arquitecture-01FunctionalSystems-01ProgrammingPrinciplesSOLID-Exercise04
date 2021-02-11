using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour, ILayerChecker
{
    public event Action<GameObject> Enter;

    [SerializeField]
    LayerMask collisionLayer;

    private void OnTriggerEnter(Collider other) 
    {
        if(ContainsLayer(other.gameObject.layer))
        {
            OnEnter(other.gameObject);
        }
    }

   

    void OnEnter(GameObject target)
    {
        Enter?.Invoke(target);
    }

   public bool ContainsLayer(int layer) => collisionLayer == (collisionLayer | (1 << layer));
}
