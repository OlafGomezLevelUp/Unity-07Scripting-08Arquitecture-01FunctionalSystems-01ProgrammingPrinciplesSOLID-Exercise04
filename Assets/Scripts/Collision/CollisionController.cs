using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CollisionBehaviour), typeof(DamageBehaviour))]

public class CollisionController : MonoBehaviour
{
    CollisionBehaviour bulletCollisionBehaviour;
    DamageBehaviour damageBehaviour;

    private void Awake() {
        bulletCollisionBehaviour = GetComponent<CollisionBehaviour>();
        damageBehaviour = GetComponent<DamageBehaviour>();
    }

    private void OnEnable() {
        bulletCollisionBehaviour.Enter += OnEnter;
    }

    private void OnDisable() {
         bulletCollisionBehaviour.Enter -= OnEnter;
    }

    void OnEnter(GameObject target)
    {
        DealDamageToTarget(target);

        Destroy(this.gameObject);
    }

    private void DealDamageToTarget(GameObject target)
    {
        HealthBehaviour _damageTarget = target.GetComponent<HealthBehaviour>();

        if (_damageTarget != null)
        {
            damageBehaviour.DoDamage(_damageTarget);
        }
    }
}
