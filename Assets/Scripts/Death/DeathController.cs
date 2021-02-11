using System;
using UnityEngine;

[RequireComponent(typeof(SpawningBehaviour), typeof(HealthBehaviour), typeof(DieBehaviour))]
public class DeathController : MonoBehaviour
{
    public static event Action<GameObject> KilledGO;

    HealthBehaviour healthBehaviour;
    SpawningBehaviour spawningBehaviour;
    DieBehaviour dieBehaviour;
    

    private void OnEnable() {
        
        healthBehaviour.Dead += OnDead;
    }

     private void OnDisable() {
        
        healthBehaviour.Dead -= OnDead;
    }

    private void Awake() {
        healthBehaviour = GetComponent<HealthBehaviour>();
        spawningBehaviour = GetComponent<SpawningBehaviour>();
        dieBehaviour = GetComponent<DieBehaviour>();
    }

    void OnDead()
    {
        OnKilledGO(gameObject);
        dieBehaviour.Die(spawningBehaviour);
    }

    void OnKilledGO(GameObject killed)
    {
        KilledGO?.Invoke(killed);
    }
}
