using System;
using UnityEngine;

[RequireComponent(typeof(CollisionBehaviour), typeof(PowerUpHealBehaviour))]
public class CollisionItems : MonoBehaviour
{

    CollisionBehaviour bulletCollisionBehaviour;
    PowerUpHealBehaviour PowerUpHealBehaviour;
    SpawningBehaviour spawning;
    
    [SerializeField]
    GameObject HealFX;


   

    private void Awake() {
        bulletCollisionBehaviour = GetComponent<CollisionBehaviour>();
        PowerUpHealBehaviour = GetComponent<PowerUpHealBehaviour>();
        spawning = GetComponent<SpawningBehaviour>();
    }

    private void OnEnable() {
        bulletCollisionBehaviour.Enter += OnEnter;
    }

    private void OnDisable() {
         bulletCollisionBehaviour.Enter -= OnEnter;
    }

    void OnEnter(GameObject target)
    {
        HealToTarget(target);
        spawning.SpawnObject(HealFX,transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    private void HealToTarget(GameObject target)
    {
        PlayerHealthBehaviour _damageTarget = target.GetComponent<PlayerHealthBehaviour>();
        LifeBarBehaviour _lifeBar = target.GetComponent<LifeBarBehaviour>();

        if (_damageTarget != null)
        {
            PowerUpHealBehaviour.Heal(_damageTarget);
           _lifeBar.RefreshLifeBarFillment(_damageTarget);
        }
    }
}
