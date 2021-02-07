using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletcollisionController : MonoBehaviour
{
    BulletCollisionBehaviour bulletCollisionBehaviour;

    private void Awake() {
        bulletCollisionBehaviour = GetComponent<BulletCollisionBehaviour>();
    }

    private void OnEnable() {
        bulletCollisionBehaviour.Enter += OnEnter;
    }

    private void OnDisable() {
         bulletCollisionBehaviour.Enter -= OnEnter;
    }

    void OnEnter()
    {
        Destroy(this.gameObject);
    }
}
